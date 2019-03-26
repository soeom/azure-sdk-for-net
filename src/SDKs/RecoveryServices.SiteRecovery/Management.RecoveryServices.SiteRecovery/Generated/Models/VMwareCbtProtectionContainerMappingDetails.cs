// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VMwareCbt provider specific container mapping details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareCbt")]
    public partial class VMwareCbtProtectionContainerMappingDetails : ProtectionContainerMappingProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VMwareCbtProtectionContainerMappingDetails class.
        /// </summary>
        public VMwareCbtProtectionContainerMappingDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VMwareCbtProtectionContainerMappingDetails class.
        /// </summary>
        /// <param name="keyVaultId">The target key vault ARM Id.</param>
        /// <param name="keyVaultUri">The target key vault URI.</param>
        /// <param name="storageAccountId">The storage account ARM Id.</param>
        /// <param name="storageAccountSasSecretName">The secret name of the
        /// storage account.</param>
        /// <param name="serviceBusConnectionStringSecretName">The secret name
        /// of the service bus connection string.</param>
        /// <param name="targetLocation">The target location.</param>
        public VMwareCbtProtectionContainerMappingDetails(string keyVaultId = default(string), string keyVaultUri = default(string), string storageAccountId = default(string), string storageAccountSasSecretName = default(string), string serviceBusConnectionStringSecretName = default(string), string targetLocation = default(string))
        {
            KeyVaultId = keyVaultId;
            KeyVaultUri = keyVaultUri;
            StorageAccountId = storageAccountId;
            StorageAccountSasSecretName = storageAccountSasSecretName;
            ServiceBusConnectionStringSecretName = serviceBusConnectionStringSecretName;
            TargetLocation = targetLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the target key vault ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultId")]
        public string KeyVaultId { get; private set; }

        /// <summary>
        /// Gets the target key vault URI.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultUri")]
        public string KeyVaultUri { get; private set; }

        /// <summary>
        /// Gets the storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; private set; }

        /// <summary>
        /// Gets the secret name of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountSasSecretName")]
        public string StorageAccountSasSecretName { get; private set; }

        /// <summary>
        /// Gets the secret name of the service bus connection string.
        /// </summary>
        [JsonProperty(PropertyName = "serviceBusConnectionStringSecretName")]
        public string ServiceBusConnectionStringSecretName { get; private set; }

        /// <summary>
        /// Gets the target location.
        /// </summary>
        [JsonProperty(PropertyName = "targetLocation")]
        public string TargetLocation { get; private set; }

    }
}