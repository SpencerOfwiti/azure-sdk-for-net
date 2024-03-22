// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_MongoDBDatabaseThroughputSettingResource
    {
        // CosmosDBMongoDBDatabaseThroughputGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBMongoDBDatabaseThroughputGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBMongoDBDatabaseThroughputGet.json
            // this example is just showing the usage of "MongoDBResources_GetMongoDBDatabaseThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseThroughputSettingResource created on azure
            // for more information of creating MongoDBDatabaseThroughputSettingResource, please refer to the document of MongoDBDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseThroughputSettingResourceId = MongoDBDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseThroughputSettingResource mongoDBDatabaseThroughputSetting = client.GetMongoDBDatabaseThroughputSettingResource(mongoDBDatabaseThroughputSettingResourceId);

            // invoke the operation
            MongoDBDatabaseThroughputSettingResource result = await mongoDBDatabaseThroughputSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBDatabaseThroughputUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBMongoDBDatabaseThroughputUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBMongoDBDatabaseThroughputUpdate.json
            // this example is just showing the usage of "MongoDBResources_UpdateMongoDBDatabaseThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseThroughputSettingResource created on azure
            // for more information of creating MongoDBDatabaseThroughputSettingResource, please refer to the document of MongoDBDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseThroughputSettingResourceId = MongoDBDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseThroughputSettingResource mongoDBDatabaseThroughputSetting = client.GetMongoDBDatabaseThroughputSettingResource(mongoDBDatabaseThroughputSettingResourceId);

            // invoke the operation
            ThroughputSettingsUpdateData data = new ThroughputSettingsUpdateData(new AzureLocation("West US"), new ThroughputSettingsResourceInfo()
            {
                Throughput = 400,
            })
            {
                Tags =
{
},
            };
            ArmOperation<MongoDBDatabaseThroughputSettingResource> lro = await mongoDBDatabaseThroughputSetting.CreateOrUpdateAsync(WaitUntil.Completed, data);
            MongoDBDatabaseThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBDatabaseMigrateToAutoscale
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateMongoDBDatabaseToAutoscale_CosmosDBMongoDBDatabaseMigrateToAutoscale()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBMongoDBDatabaseMigrateToAutoscale.json
            // this example is just showing the usage of "MongoDBResources_MigrateMongoDBDatabaseToAutoscale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseThroughputSettingResource created on azure
            // for more information of creating MongoDBDatabaseThroughputSettingResource, please refer to the document of MongoDBDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseThroughputSettingResourceId = MongoDBDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseThroughputSettingResource mongoDBDatabaseThroughputSetting = client.GetMongoDBDatabaseThroughputSettingResource(mongoDBDatabaseThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<MongoDBDatabaseThroughputSettingResource> lro = await mongoDBDatabaseThroughputSetting.MigrateMongoDBDatabaseToAutoscaleAsync(WaitUntil.Completed);
            MongoDBDatabaseThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBDatabaseMigrateToManualThroughput
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateMongoDBDatabaseToManualThroughput_CosmosDBMongoDBDatabaseMigrateToManualThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBMongoDBDatabaseMigrateToManualThroughput.json
            // this example is just showing the usage of "MongoDBResources_MigrateMongoDBDatabaseToManualThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseThroughputSettingResource created on azure
            // for more information of creating MongoDBDatabaseThroughputSettingResource, please refer to the document of MongoDBDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseThroughputSettingResourceId = MongoDBDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseThroughputSettingResource mongoDBDatabaseThroughputSetting = client.GetMongoDBDatabaseThroughputSettingResource(mongoDBDatabaseThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<MongoDBDatabaseThroughputSettingResource> lro = await mongoDBDatabaseThroughputSetting.MigrateMongoDBDatabaseToManualThroughputAsync(WaitUntil.Completed);
            MongoDBDatabaseThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBDatabaseRetrieveThroughputDistribution
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MongoDBDatabaseRetrieveThroughputDistribution_CosmosDBMongoDBDatabaseRetrieveThroughputDistribution()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBMongoDBDatabaseRetrieveThroughputDistribution.json
            // this example is just showing the usage of "MongoDBResources_MongoDBDatabaseRetrieveThroughputDistribution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseThroughputSettingResource created on azure
            // for more information of creating MongoDBDatabaseThroughputSettingResource, please refer to the document of MongoDBDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseThroughputSettingResourceId = MongoDBDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseThroughputSettingResource mongoDBDatabaseThroughputSetting = client.GetMongoDBDatabaseThroughputSettingResource(mongoDBDatabaseThroughputSettingResourceId);

            // invoke the operation
            RetrieveThroughputParameters retrieveThroughputParameters = new RetrieveThroughputParameters(new AzureLocation("placeholder"), new RetrieveThroughputPropertiesResource(new WritableSubResource[]
            {
new WritableSubResource()
{
Id = new ResourceIdentifier("0"),
},new WritableSubResource()
{
Id = new ResourceIdentifier("1"),
}
            }));
            ArmOperation<PhysicalPartitionThroughputInfoResult> lro = await mongoDBDatabaseThroughputSetting.MongoDBDatabaseRetrieveThroughputDistributionAsync(WaitUntil.Completed, retrieveThroughputParameters);
            PhysicalPartitionThroughputInfoResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBMongoDBDatabaseRedistributeThroughput
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MongoDBDatabaseRedistributeThroughput_CosmosDBMongoDBDatabaseRedistributeThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBMongoDBDatabaseRedistributeThroughput.json
            // this example is just showing the usage of "MongoDBResources_MongoDBDatabaseRedistributeThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseThroughputSettingResource created on azure
            // for more information of creating MongoDBDatabaseThroughputSettingResource, please refer to the document of MongoDBDatabaseThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseThroughputSettingResourceId = MongoDBDatabaseThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseThroughputSettingResource mongoDBDatabaseThroughputSetting = client.GetMongoDBDatabaseThroughputSettingResource(mongoDBDatabaseThroughputSettingResourceId);

            // invoke the operation
            RedistributeThroughputParameters redistributeThroughputParameters = new RedistributeThroughputParameters(new AzureLocation("placeholder"), new RedistributeThroughputPropertiesResource(ThroughputPolicyType.Custom, new PhysicalPartitionThroughputInfoResource[]
            {
new PhysicalPartitionThroughputInfoResource("0")
{
Throughput = 5000,
},new PhysicalPartitionThroughputInfoResource("1")
{
Throughput = 5000,
}
            }, new PhysicalPartitionThroughputInfoResource[]
            {
new PhysicalPartitionThroughputInfoResource("2")
{
Throughput = 5000,
},new PhysicalPartitionThroughputInfoResource("3")
            }));
            ArmOperation<PhysicalPartitionThroughputInfoResult> lro = await mongoDBDatabaseThroughputSetting.MongoDBDatabaseRedistributeThroughputAsync(WaitUntil.Completed, redistributeThroughputParameters);
            PhysicalPartitionThroughputInfoResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
