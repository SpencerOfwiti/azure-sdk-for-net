// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBFirewallRuleCollection
    {
        // Create a firewall rule of the mongo cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAFirewallRuleOfTheMongoCluster()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/mongo-cluster/CosmosDBMongoClusterFirewallRuleCreate.json
            // this example is just showing the usage of "MongoClusters_CreateOrUpdateFirewallRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterResource created on azure
            // for more information of creating MongoClusterResource, please refer to the document of MongoClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            ResourceIdentifier mongoClusterResourceId = MongoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName);
            MongoClusterResource mongoCluster = client.GetMongoClusterResource(mongoClusterResourceId);

            // get the collection of this CosmosDBFirewallRuleResource
            CosmosDBFirewallRuleCollection collection = mongoCluster.GetCosmosDBFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            CosmosDBFirewallRuleData data = new CosmosDBFirewallRuleData("0.0.0.0", "255.255.255.255");
            ArmOperation<CosmosDBFirewallRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallRuleName, data);
            CosmosDBFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the firewall rule of the mongo cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheFirewallRuleOfTheMongoCluster()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/mongo-cluster/CosmosDBMongoClusterFirewallRuleGet.json
            // this example is just showing the usage of "MongoClusters_GetFirewallRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterResource created on azure
            // for more information of creating MongoClusterResource, please refer to the document of MongoClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            ResourceIdentifier mongoClusterResourceId = MongoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName);
            MongoClusterResource mongoCluster = client.GetMongoClusterResource(mongoClusterResourceId);

            // get the collection of this CosmosDBFirewallRuleResource
            CosmosDBFirewallRuleCollection collection = mongoCluster.GetCosmosDBFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            CosmosDBFirewallRuleResource result = await collection.GetAsync(firewallRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the firewall rule of the mongo cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheFirewallRuleOfTheMongoCluster()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/mongo-cluster/CosmosDBMongoClusterFirewallRuleGet.json
            // this example is just showing the usage of "MongoClusters_GetFirewallRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterResource created on azure
            // for more information of creating MongoClusterResource, please refer to the document of MongoClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            ResourceIdentifier mongoClusterResourceId = MongoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName);
            MongoClusterResource mongoCluster = client.GetMongoClusterResource(mongoClusterResourceId);

            // get the collection of this CosmosDBFirewallRuleResource
            CosmosDBFirewallRuleCollection collection = mongoCluster.GetCosmosDBFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            bool result = await collection.ExistsAsync(firewallRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the firewall rule of the mongo cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheFirewallRuleOfTheMongoCluster()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/mongo-cluster/CosmosDBMongoClusterFirewallRuleGet.json
            // this example is just showing the usage of "MongoClusters_GetFirewallRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterResource created on azure
            // for more information of creating MongoClusterResource, please refer to the document of MongoClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            ResourceIdentifier mongoClusterResourceId = MongoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName);
            MongoClusterResource mongoCluster = client.GetMongoClusterResource(mongoClusterResourceId);

            // get the collection of this CosmosDBFirewallRuleResource
            CosmosDBFirewallRuleCollection collection = mongoCluster.GetCosmosDBFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            NullableResponse<CosmosDBFirewallRuleResource> response = await collection.GetIfExistsAsync(firewallRuleName);
            CosmosDBFirewallRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBFirewallRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List firewall rules of the mongo cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListFirewallRulesOfTheMongoCluster()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/mongo-cluster/CosmosDBMongoClusterFirewallRuleList.json
            // this example is just showing the usage of "MongoClusters_ListFirewallRules" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterResource created on azure
            // for more information of creating MongoClusterResource, please refer to the document of MongoClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            ResourceIdentifier mongoClusterResourceId = MongoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName);
            MongoClusterResource mongoCluster = client.GetMongoClusterResource(mongoClusterResourceId);

            // get the collection of this CosmosDBFirewallRuleResource
            CosmosDBFirewallRuleCollection collection = mongoCluster.GetCosmosDBFirewallRules();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBFirewallRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBFirewallRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
