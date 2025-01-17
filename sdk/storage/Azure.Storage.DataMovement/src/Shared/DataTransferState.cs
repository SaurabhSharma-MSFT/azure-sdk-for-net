﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// Defines the state of the transfer
    /// </summary>
    internal class DataTransferState
    {
        private readonly object _statusLock = new object();
        private string _id;
        private DataTransferStatus _status;

        public TaskCompletionSource<DataTransferStatus> CompletionSource;

        public CancellationTokenSource CancellationTokenSource { get; internal set; }

        public DataTransferStatus Status => _status;

        /// <summary>
        /// Constructor to resume current jobs
        /// </summary>
        /// <param name="id">The transfer ID of the transfer object.</param>
        /// <param name="status">The Transfer Status of the Transfer. See <see cref="DataTransferStatus"/>.</param>
        public DataTransferState(
            string id = default,
            DataTransferStatus status = DataTransferStatus.Queued)
        {
            _id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
            _status = status;
            CompletionSource = new TaskCompletionSource<DataTransferStatus>(
                _status,
                TaskCreationOptions.RunContinuationsAsynchronously);
            if (DataTransferStatus.Completed == status ||
                        DataTransferStatus.CompletedWithSkippedTransfers == status ||
                        DataTransferStatus.CompletedWithFailedTransfers == status)
            {
                CompletionSource.TrySetResult(status);
            }
            CancellationTokenSource = new CancellationTokenSource();
        }

        /// <summary>
        /// Gets the identifier of the transfer state
        /// </summary>
        public string Id
        {
            get { return _id; }
            internal set { }
        }

        /// <summary>
        /// Defines whether the transfer is completed
        /// </summary>
        public bool HasCompleted
        {
            get {
                return (DataTransferStatus.Completed == _status ||
                        DataTransferStatus.CompletedWithSkippedTransfers == _status ||
                        DataTransferStatus.CompletedWithFailedTransfers == _status);
            }
            internal set { }
        }

        /// <summary>
        /// Sets the id of the transfer
        /// </summary>
        /// <param name="id"></param>
        public void SetId(string id)
        {
            _id = id;
        }

        /// <summary>
        /// Gets the status of the transfer
        /// </summary>
        /// <returns></returns>
        public DataTransferStatus GetTransferStatus()
        {
            lock (_statusLock)
            {
                return _status;
            }
        }

        /// <summary>
        /// Sets the completion status
        /// </summary>
        /// <param name="status"></param>
        /// <returns>Returns whether or not the status has been changed/set</returns>
        public bool TrySetTransferStatus(DataTransferStatus status)
        {
            lock (_statusLock)
            {
                if (_status != status)
                {
                    _status = status;
                    if (DataTransferStatus.Paused == status ||
                        DataTransferStatus.Completed == status ||
                        DataTransferStatus.CompletedWithSkippedTransfers == status ||
                        DataTransferStatus.CompletedWithFailedTransfers == status)
                    {
                        // If the _completionSource has been cancelled or the exception
                        // has been set, we don't need to check if TrySetResult returns false
                        // because it's acceptable to cancel or have an error occur before then.
                        CompletionSource.TrySetResult(status);
                    }
                    return true;
                }
                return false;
            }
        }

        internal bool CanPause()
            => _status == DataTransferStatus.InProgress;

        public async Task PauseIfRunningAsync(CancellationToken cancellationToken)
        {
            if (!CanPause())
            {
                return;
            }
            CancellationHelper.ThrowIfCancellationRequested(cancellationToken);
            // Call the inner cancellation token to stop the transfer job
            TrySetTransferStatus(DataTransferStatus.PauseInProgress);
            if (TriggerCancellation())
            {
                // Wait until full pause has completed.
                await CompletionSource.Task.AwaitWithCancellation(cancellationToken);
            }
        }

        internal bool TriggerCancellation()
        {
            if (!CancellationTokenSource.IsCancellationRequested)
            {
                CancellationTokenSource.Cancel();
                return true;
            }
            return false;
        }
    }
}
