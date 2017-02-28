// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Azure;
    using Management;
    using Sql;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a database transparent data encryption Scan.
    /// </summary>
    [JsonTransformation]
    public partial class TransparentDataEncryptionActivity : SqlSubResource
    {
        /// <summary>
        /// Initializes a new instance of the TransparentDataEncryptionActivity
        /// class.
        /// </summary>
        public TransparentDataEncryptionActivity() { }

        /// <summary>
        /// Initializes a new instance of the TransparentDataEncryptionActivity
        /// class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="status">The status of the database. Possible values
        /// include: 'Encrypting', 'Decrypting'</param>
        /// <param name="percentComplete">The percent complete of the
        /// transparent data encryption scan for a database.</param>
        public TransparentDataEncryptionActivity(string name = default(string), string id = default(string), string status = default(string), double? percentComplete = default(double?))
            : base(name, id)
        {
            Status = status;
            PercentComplete = percentComplete;
        }

        /// <summary>
        /// Gets the status of the database. Possible values include:
        /// 'Encrypting', 'Decrypting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; protected set; }

        /// <summary>
        /// Gets the percent complete of the transparent data encryption scan
        /// for a database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.percentComplete")]
        public double? PercentComplete { get; protected set; }

    }
}

