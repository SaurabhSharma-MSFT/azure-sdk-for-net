// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Online deployment scaling configuration. </summary>
    public partial class OnlineScaleSettings
    {
        /// <summary> Initializes a new instance of OnlineScaleSettings. </summary>
        public OnlineScaleSettings()
        {
        }

        /// <summary> Initializes a new instance of OnlineScaleSettings. </summary>
        /// <param name="maxInstances"> Maximum number of instances for this deployment. </param>
        /// <param name="minInstances"> Minimum number of instances for this deployment. </param>
        /// <param name="scaleType"> Type of deployment scaling algorithm. </param>
        internal OnlineScaleSettings(int? maxInstances, int? minInstances, ScaleType scaleType)
        {
            MaxInstances = maxInstances;
            MinInstances = minInstances;
            ScaleType = scaleType;
        }

        /// <summary> Maximum number of instances for this deployment. </summary>
        public int? MaxInstances { get; set; }
        /// <summary> Minimum number of instances for this deployment. </summary>
        public int? MinInstances { get; set; }
        /// <summary> Type of deployment scaling algorithm. </summary>
        internal ScaleType ScaleType { get; set; }
    }
}
