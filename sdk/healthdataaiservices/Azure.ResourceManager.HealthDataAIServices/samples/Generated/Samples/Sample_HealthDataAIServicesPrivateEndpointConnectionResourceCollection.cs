// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HealthDataAIServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HealthDataAIServices.Samples
{
    public partial class Sample_HealthDataAIServicesPrivateEndpointConnectionResourceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionsGetGeneratedByMaximumSetRuleStable()
        {
            // Generated from example definition: 2024-09-20/PrivateEndpointConnections_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnectionResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeidServiceResource created on azure
            // for more information of creating DeidServiceResource, please refer to the document of DeidServiceResource
            string subscriptionId = "F21BB31B-C214-42C0-ACF0-DACCA05D3011";
            string resourceGroupName = "rgopenapi";
            string deidServiceName = "deidTest";
            ResourceIdentifier deidServiceResourceId = DeidServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deidServiceName);
            DeidServiceResource deidService = client.GetDeidServiceResource(deidServiceResourceId);

            // get the collection of this HealthDataAIServicesPrivateEndpointConnectionResource
            HealthDataAIServicesPrivateEndpointConnectionResourceCollection collection = deidService.GetHealthDataAIServicesPrivateEndpointConnectionResources();

            // invoke the operation
            string privateEndpointConnectionName = "kgwgrrpabvrsrrvpcgcnfmyfgyrl";
            HealthDataAIServicesPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthDataAIServicesPrivateEndpointConnectionResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_PrivateEndpointConnectionsGetGeneratedByMaximumSetRuleStable()
        {
            // Generated from example definition: 2024-09-20/PrivateEndpointConnections_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnectionResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeidServiceResource created on azure
            // for more information of creating DeidServiceResource, please refer to the document of DeidServiceResource
            string subscriptionId = "F21BB31B-C214-42C0-ACF0-DACCA05D3011";
            string resourceGroupName = "rgopenapi";
            string deidServiceName = "deidTest";
            ResourceIdentifier deidServiceResourceId = DeidServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deidServiceName);
            DeidServiceResource deidService = client.GetDeidServiceResource(deidServiceResourceId);

            // get the collection of this HealthDataAIServicesPrivateEndpointConnectionResource
            HealthDataAIServicesPrivateEndpointConnectionResourceCollection collection = deidService.GetHealthDataAIServicesPrivateEndpointConnectionResources();

            // invoke the operation
            string privateEndpointConnectionName = "kgwgrrpabvrsrrvpcgcnfmyfgyrl";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_PrivateEndpointConnectionsGetGeneratedByMaximumSetRuleStable()
        {
            // Generated from example definition: 2024-09-20/PrivateEndpointConnections_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnectionResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeidServiceResource created on azure
            // for more information of creating DeidServiceResource, please refer to the document of DeidServiceResource
            string subscriptionId = "F21BB31B-C214-42C0-ACF0-DACCA05D3011";
            string resourceGroupName = "rgopenapi";
            string deidServiceName = "deidTest";
            ResourceIdentifier deidServiceResourceId = DeidServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deidServiceName);
            DeidServiceResource deidService = client.GetDeidServiceResource(deidServiceResourceId);

            // get the collection of this HealthDataAIServicesPrivateEndpointConnectionResource
            HealthDataAIServicesPrivateEndpointConnectionResourceCollection collection = deidService.GetHealthDataAIServicesPrivateEndpointConnectionResources();

            // invoke the operation
            string privateEndpointConnectionName = "kgwgrrpabvrsrrvpcgcnfmyfgyrl";
            NullableResponse<HealthDataAIServicesPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            HealthDataAIServicesPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthDataAIServicesPrivateEndpointConnectionResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionsCreateGeneratedByMaximumSetRuleStable()
        {
            // Generated from example definition: 2024-09-20/PrivateEndpointConnections_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnectionResource_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeidServiceResource created on azure
            // for more information of creating DeidServiceResource, please refer to the document of DeidServiceResource
            string subscriptionId = "F21BB31B-C214-42C0-ACF0-DACCA05D3011";
            string resourceGroupName = "rgopenapi";
            string deidServiceName = "deidTest";
            ResourceIdentifier deidServiceResourceId = DeidServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deidServiceName);
            DeidServiceResource deidService = client.GetDeidServiceResource(deidServiceResourceId);

            // get the collection of this HealthDataAIServicesPrivateEndpointConnectionResource
            HealthDataAIServicesPrivateEndpointConnectionResourceCollection collection = deidService.GetHealthDataAIServicesPrivateEndpointConnectionResources();

            // invoke the operation
            string privateEndpointConnectionName = "kgwgrrpabvrsrrvpcgcnfmyfgyrl";
            HealthDataAIServicesPrivateEndpointConnectionResourceData data = new HealthDataAIServicesPrivateEndpointConnectionResourceData()
            {
                Properties = new PrivateEndpointConnectionProperties(new HealthDataAIServicesPrivateLinkServiceConnectionState()
                {
                    Status = HealthDataAIServicesPrivateEndpointServiceConnectionStatus.Pending,
                    Description = "xr",
                    ActionsRequired = "ulb",
                }),
            };
            ArmOperation<HealthDataAIServicesPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            HealthDataAIServicesPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthDataAIServicesPrivateEndpointConnectionResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_PrivateEndpointConnectionsListByDeidServiceGeneratedByMaximumSetRuleStable()
        {
            // Generated from example definition: 2024-09-20/PrivateEndpointConnections_ListByDeidService_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnectionResource_ListByDeidService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeidServiceResource created on azure
            // for more information of creating DeidServiceResource, please refer to the document of DeidServiceResource
            string subscriptionId = "F21BB31B-C214-42C0-ACF0-DACCA05D3011";
            string resourceGroupName = "rgopenapi";
            string deidServiceName = "deidTest";
            ResourceIdentifier deidServiceResourceId = DeidServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deidServiceName);
            DeidServiceResource deidService = client.GetDeidServiceResource(deidServiceResourceId);

            // get the collection of this HealthDataAIServicesPrivateEndpointConnectionResource
            HealthDataAIServicesPrivateEndpointConnectionResourceCollection collection = deidService.GetHealthDataAIServicesPrivateEndpointConnectionResources();

            // invoke the operation and iterate over the result
            await foreach (HealthDataAIServicesPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthDataAIServicesPrivateEndpointConnectionResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
