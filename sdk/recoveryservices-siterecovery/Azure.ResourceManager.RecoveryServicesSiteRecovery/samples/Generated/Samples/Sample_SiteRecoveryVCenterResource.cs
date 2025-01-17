// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryVCenterResource
    {
        // Gets the details of a vCenter.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDetailsOfAVCenter()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/ReplicationvCenters_Get.json
            // this example is just showing the usage of "ReplicationvCenters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryVCenterResource created on azure
            // for more information of creating SiteRecoveryVCenterResource, please refer to the document of SiteRecoveryVCenterResource
            string subscriptionId = "7c943c1b-5122-4097-90c8-861411bdd574";
            string resourceGroupName = "MadhaviVRG";
            string resourceName = "MadhaviVault";
            string fabricName = "MadhaviFabric";
            string vCenterName = "esx-78";
            ResourceIdentifier siteRecoveryVCenterResourceId = SiteRecoveryVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, vCenterName);
            SiteRecoveryVCenterResource siteRecoveryVCenter = client.GetSiteRecoveryVCenterResource(siteRecoveryVCenterResourceId);

            // invoke the operation
            SiteRecoveryVCenterResource result = await siteRecoveryVCenter.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryVCenterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Remove vCenter operation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RemoveVCenterOperation()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/ReplicationvCenters_Delete.json
            // this example is just showing the usage of "ReplicationvCenters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryVCenterResource created on azure
            // for more information of creating SiteRecoveryVCenterResource, please refer to the document of SiteRecoveryVCenterResource
            string subscriptionId = "7c943c1b-5122-4097-90c8-861411bdd574";
            string resourceGroupName = "MadhaviVRG";
            string resourceName = "MadhaviVault";
            string fabricName = "MadhaviFabric";
            string vCenterName = "esx-78";
            ResourceIdentifier siteRecoveryVCenterResourceId = SiteRecoveryVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, vCenterName);
            SiteRecoveryVCenterResource siteRecoveryVCenter = client.GetSiteRecoveryVCenterResource(siteRecoveryVCenterResourceId);

            // invoke the operation
            await siteRecoveryVCenter.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update vCenter operation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVCenterOperation()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/ReplicationvCenters_Update.json
            // this example is just showing the usage of "ReplicationvCenters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryVCenterResource created on azure
            // for more information of creating SiteRecoveryVCenterResource, please refer to the document of SiteRecoveryVCenterResource
            string subscriptionId = "7c943c1b-5122-4097-90c8-861411bdd574";
            string resourceGroupName = "MadhaviVRG";
            string resourceName = "MadhaviVault";
            string fabricName = "MadhaviFabric";
            string vCenterName = "esx-78";
            ResourceIdentifier siteRecoveryVCenterResourceId = SiteRecoveryVCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, vCenterName);
            SiteRecoveryVCenterResource siteRecoveryVCenter = client.GetSiteRecoveryVCenterResource(siteRecoveryVCenterResourceId);

            // invoke the operation
            SiteRecoveryVCenterPatch patch = new SiteRecoveryVCenterPatch()
            {
                Properties = new SiteRecoveryUpdateVCenterProperties()
                {
                    IPAddress = IPAddress.Parse("10.150.109.25"),
                },
            };
            ArmOperation<SiteRecoveryVCenterResource> lro = await siteRecoveryVCenter.UpdateAsync(WaitUntil.Completed, patch);
            SiteRecoveryVCenterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryVCenterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the list of vCenter registered under the vault.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSiteRecoveryVCenters_GetsTheListOfVCenterRegisteredUnderTheVault()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/ReplicationvCenters_List.json
            // this example is just showing the usage of "ReplicationvCenters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "7c943c1b-5122-4097-90c8-861411bdd574";
            string resourceGroupName = "MadhaviVRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string resourceName = "MadhaviVault";
            await foreach (SiteRecoveryVCenterResource item in resourceGroupResource.GetSiteRecoveryVCentersAsync(resourceName))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SiteRecoveryVCenterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
