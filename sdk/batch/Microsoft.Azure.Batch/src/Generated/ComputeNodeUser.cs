// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A user account for remote access to a compute node.
    /// </summary>
    public partial class ComputeNodeUser : ITransportObjectProvider<Models.ComputeNodeUser>, IInheritedBehaviors, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<DateTime> ExpiryTimeProperty;
            public readonly PropertyAccessor<bool?> IsAdminProperty;
            public readonly PropertyAccessor<string> NameProperty;
            public readonly PropertyAccessor<string> PasswordProperty;
            public readonly PropertyAccessor<string> SshPublicKeyProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.ExpiryTimeProperty = this.CreatePropertyAccessor<DateTime>(nameof(ExpiryTime), BindingAccess.Read | BindingAccess.Write);
                this.IsAdminProperty = this.CreatePropertyAccessor<bool?>(nameof(IsAdmin), BindingAccess.Read | BindingAccess.Write);
                this.NameProperty = this.CreatePropertyAccessor<string>(nameof(Name), BindingAccess.Read | BindingAccess.Write);
                this.PasswordProperty = this.CreatePropertyAccessor<string>(nameof(Password), BindingAccess.Read | BindingAccess.Write);
                this.SshPublicKeyProperty = this.CreatePropertyAccessor<string>(nameof(SshPublicKey), BindingAccess.Read | BindingAccess.Write);
            }

        }

        private PropertyContainer propertyContainer;

        private readonly BatchClient parentBatchClient;
        private readonly string parentPoolId;

        internal string ParentPoolId
        {
            get
            {
                return this.parentPoolId;
            }
        }
        private readonly string parentNodeId;

        internal string ParentNodeId
        {
            get
            {
                return this.parentNodeId;
            }
        }

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeNodeUser"/> class.
        /// </summary>
        /// <param name='parentBatchClient'>The parent <see cref="BatchClient"/> to use.</param>
        /// <param name='baseBehaviors'>The base behaviors to use.</param>
        /// <param name='parentPoolId'>The parentPoolId.</param>
        /// <param name='parentNodeId'>The parentNodeId.</param>
        internal ComputeNodeUser(
            BatchClient parentBatchClient,
            IEnumerable<BatchClientBehavior> baseBehaviors,
            string parentPoolId,
            string parentNodeId)
        {
            this.propertyContainer = new PropertyContainer();
            this.parentBatchClient = parentBatchClient;
            this.parentPoolId = parentPoolId;
            this.parentNodeId = parentNodeId;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
        }

        /// <summary>
        /// Default constructor to support mocking the <see cref="ComputeNodeUser"/> class.
        /// </summary>
        protected ComputeNodeUser()
        {
            this.propertyContainer = new PropertyContainer();
        }


        #endregion Constructors

        #region IInheritedBehaviors

        /// <summary>
        /// Gets or sets a list of behaviors that modify or customize requests to the Batch service
        /// made via this <see cref="ComputeNodeUser"/>.
        /// </summary>
        /// <remarks>
        /// <para>These behaviors are inherited by child objects.</para>
        /// <para>Modifications are applied in the order of the collection. The last write wins.</para>
        /// </remarks>
        public IList<BatchClientBehavior> CustomBehaviors { get; set; }

        #endregion IInheritedBehaviors

        #region ComputeNodeUser

        /// <summary>
        /// Gets or sets the expiry time.
        /// </summary>
        public DateTime ExpiryTime
        {
            get { return this.propertyContainer.ExpiryTimeProperty.Value; }
            set { this.propertyContainer.ExpiryTimeProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the administrative privilege level of the user account. The value of this property is ignored when 
        /// UpdateUser is specified for the commit operation.
        /// </summary>
        public bool? IsAdmin
        {
            get { return this.propertyContainer.IsAdminProperty.Value; }
            set { this.propertyContainer.IsAdminProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the name. If AddUser is specified for the commit operation, the value of this property is the name 
        /// of the local Windows account created. If UpdateUser is specified for the commit operation, the value of this 
        /// property selects the local Windows account to modify. Changing this property does not rename the local Windows 
        /// account on the compute node.
        /// </summary>
        public string Name
        {
            get { return this.propertyContainer.NameProperty.Value; }
            set { this.propertyContainer.NameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password
        {
            get { return this.propertyContainer.PasswordProperty.Value; }
            set { this.propertyContainer.PasswordProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the SSH public key that can be used for remote login to the compute node.
        /// </summary>
        /// <remarks>
        /// <para>The public key should be compatible with Open SSH encoding and should be base 64 encoded. This property 
        /// can be specified only for Linux nodes. The Batch service will return an error if this property is set for pools 
        /// created with <see cref="Microsoft.Azure.Batch.CloudServiceConfiguration"/> or <see cref="Microsoft.Azure.Batch.VirtualMachineConfiguration"/> 
        /// with Windows compute nodes.</para>
        /// </remarks>
        public string SshPublicKey
        {
            get { return this.propertyContainer.SshPublicKeyProperty.Value; }
            set { this.propertyContainer.SshPublicKeyProperty.Value = value; }
        }

        #endregion // ComputeNodeUser

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ComputeNodeUser ITransportObjectProvider<Models.ComputeNodeUser>.GetTransportObject()
        {
            Models.ComputeNodeUser result = new Models.ComputeNodeUser()
            {
                ExpiryTime = this.ExpiryTime,
                IsAdmin = this.IsAdmin,
                Name = this.Name,
                Password = this.Password,
                SshPublicKey = this.SshPublicKey,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}