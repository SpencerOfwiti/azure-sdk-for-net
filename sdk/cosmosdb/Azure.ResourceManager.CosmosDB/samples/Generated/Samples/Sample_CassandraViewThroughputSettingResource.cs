// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CassandraViewThroughputSettingResource
    {
        // CosmosDBCassandraViewThroughputGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBCassandraViewThroughputGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraViewThroughputGet.json
            // this example is just showing the usage of "CassandraResources_GetCassandraViewThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraViewThroughputSettingResource created on azure
            // for more information of creating CassandraViewThroughputSettingResource, please refer to the document of CassandraViewThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspacename";
            string viewName = "viewname";
            ResourceIdentifier cassandraViewThroughputSettingResourceId = CassandraViewThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, viewName);
            CassandraViewThroughputSettingResource cassandraViewThroughputSetting = client.GetCassandraViewThroughputSettingResource(cassandraViewThroughputSettingResourceId);

            // invoke the operation
            CassandraViewThroughputSettingResource result = await cassandraViewThroughputSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraViewThroughputUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBCassandraViewThroughputUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraViewThroughputUpdate.json
            // this example is just showing the usage of "CassandraResources_UpdateCassandraViewThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraViewThroughputSettingResource created on azure
            // for more information of creating CassandraViewThroughputSettingResource, please refer to the document of CassandraViewThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspacename";
            string viewName = "viewname";
            ResourceIdentifier cassandraViewThroughputSettingResourceId = CassandraViewThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, viewName);
            CassandraViewThroughputSettingResource cassandraViewThroughputSetting = client.GetCassandraViewThroughputSettingResource(cassandraViewThroughputSettingResourceId);

            // invoke the operation
            ThroughputSettingsUpdateData data = new ThroughputSettingsUpdateData(new AzureLocation("placeholder"), new ThroughputSettingsResourceInfo()
            {
                Throughput = 400,
            })
            {
                Tags =
{
},
            };
            ArmOperation<CassandraViewThroughputSettingResource> lro = await cassandraViewThroughputSetting.CreateOrUpdateAsync(WaitUntil.Completed, data);
            CassandraViewThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraViewMigrateToAutoscale
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateCassandraViewToAutoscale_CosmosDBCassandraViewMigrateToAutoscale()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraViewMigrateToAutoscale.json
            // this example is just showing the usage of "CassandraResources_MigrateCassandraViewToAutoscale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraViewThroughputSettingResource created on azure
            // for more information of creating CassandraViewThroughputSettingResource, please refer to the document of CassandraViewThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspacename";
            string viewName = "viewname";
            ResourceIdentifier cassandraViewThroughputSettingResourceId = CassandraViewThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, viewName);
            CassandraViewThroughputSettingResource cassandraViewThroughputSetting = client.GetCassandraViewThroughputSettingResource(cassandraViewThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CassandraViewThroughputSettingResource> lro = await cassandraViewThroughputSetting.MigrateCassandraViewToAutoscaleAsync(WaitUntil.Completed);
            CassandraViewThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraViewMigrateToManualThroughput
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateCassandraViewToManualThroughput_CosmosDBCassandraViewMigrateToManualThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraViewMigrateToManualThroughput.json
            // this example is just showing the usage of "CassandraResources_MigrateCassandraViewToManualThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraViewThroughputSettingResource created on azure
            // for more information of creating CassandraViewThroughputSettingResource, please refer to the document of CassandraViewThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspacename";
            string viewName = "viewname";
            ResourceIdentifier cassandraViewThroughputSettingResourceId = CassandraViewThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, viewName);
            CassandraViewThroughputSettingResource cassandraViewThroughputSetting = client.GetCassandraViewThroughputSettingResource(cassandraViewThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CassandraViewThroughputSettingResource> lro = await cassandraViewThroughputSetting.MigrateCassandraViewToManualThroughputAsync(WaitUntil.Completed);
            CassandraViewThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
