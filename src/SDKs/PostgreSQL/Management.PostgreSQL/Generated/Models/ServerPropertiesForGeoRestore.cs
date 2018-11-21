// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties used to create a new server by restoring to a different
    /// region from a geo replicated backup.
    /// </summary>
    [Newtonsoft.Json.JsonObject("GeoRestore")]
    public partial class ServerPropertiesForGeoRestore : ServerPropertiesForCreate
    {
        /// <summary>
        /// Initializes a new instance of the ServerPropertiesForGeoRestore
        /// class.
        /// </summary>
        public ServerPropertiesForGeoRestore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerPropertiesForGeoRestore
        /// class.
        /// </summary>
        /// <param name="sourceServerId">The source server id to restore
        /// from.</param>
        /// <param name="version">Server version. Possible values include:
        /// '9.5', '9.6'</param>
        /// <param name="sslEnforcement">Enable ssl enforcement or not when
        /// connect to server. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="storageProfile">Storage profile of a server.</param>
        public ServerPropertiesForGeoRestore(string sourceServerId, string version = default(string), SslEnforcementEnum? sslEnforcement = default(SslEnforcementEnum?), StorageProfile storageProfile = default(StorageProfile))
            : base(version, sslEnforcement, storageProfile)
        {
            SourceServerId = sourceServerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source server id to restore from.
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerId")]
        public string SourceServerId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceServerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceServerId");
            }
        }
    }
}