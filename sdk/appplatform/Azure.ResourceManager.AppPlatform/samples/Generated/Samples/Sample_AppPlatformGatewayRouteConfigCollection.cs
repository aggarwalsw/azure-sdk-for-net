// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppPlatform.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformGatewayRouteConfigCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_GatewayRouteConfigsCreateOrUpdate()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayRouteConfigs_CreateOrUpdate.json
            // this example is just showing the usage of "GatewayRouteConfigs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayRouteConfigResource
            AppPlatformGatewayRouteConfigCollection collection = appPlatformGateway.GetAppPlatformGatewayRouteConfigs();

            // invoke the operation
            string routeConfigName = "myRouteConfig";
            AppPlatformGatewayRouteConfigData data = new AppPlatformGatewayRouteConfigData
            {
                Properties = new AppPlatformGatewayRouteConfigProperties
                {
                    AppResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.AppPlatform/Spring/myservice/apps/myApp"),
                    OpenApiUri = new Uri("https://raw.githubusercontent.com/OAI/OpenAPI-Specification/main/examples/v3.0/petstore.json"),
                    Protocol = AppPlatformGatewayRouteConfigProtocol.Https,
                    Routes = {new AppPlatformGatewayApiRoute
{
Title = "myApp route config",
IsSsoEnabled = true,
Predicates = {"Path=/api5/customer/**"},
Filters = {"StripPrefix=2", "RateLimit=1,1s"},
}},
                },
            };
            ArmOperation<AppPlatformGatewayRouteConfigResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, routeConfigName, data);
            AppPlatformGatewayRouteConfigResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformGatewayRouteConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GatewayRouteConfigsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayRouteConfigs_Get.json
            // this example is just showing the usage of "GatewayRouteConfigs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayRouteConfigResource
            AppPlatformGatewayRouteConfigCollection collection = appPlatformGateway.GetAppPlatformGatewayRouteConfigs();

            // invoke the operation
            string routeConfigName = "myRouteConfig";
            AppPlatformGatewayRouteConfigResource result = await collection.GetAsync(routeConfigName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformGatewayRouteConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GatewayRouteConfigsList()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayRouteConfigs_List.json
            // this example is just showing the usage of "GatewayRouteConfigs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayRouteConfigResource
            AppPlatformGatewayRouteConfigCollection collection = appPlatformGateway.GetAppPlatformGatewayRouteConfigs();

            // invoke the operation and iterate over the result
            await foreach (AppPlatformGatewayRouteConfigResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformGatewayRouteConfigData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GatewayRouteConfigsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayRouteConfigs_Get.json
            // this example is just showing the usage of "GatewayRouteConfigs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayRouteConfigResource
            AppPlatformGatewayRouteConfigCollection collection = appPlatformGateway.GetAppPlatformGatewayRouteConfigs();

            // invoke the operation
            string routeConfigName = "myRouteConfig";
            bool result = await collection.ExistsAsync(routeConfigName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GatewayRouteConfigsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/GatewayRouteConfigs_Get.json
            // this example is just showing the usage of "GatewayRouteConfigs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformGatewayResource created on azure
            // for more information of creating AppPlatformGatewayResource, please refer to the document of AppPlatformGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string gatewayName = "default";
            ResourceIdentifier appPlatformGatewayResourceId = AppPlatformGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayName);
            AppPlatformGatewayResource appPlatformGateway = client.GetAppPlatformGatewayResource(appPlatformGatewayResourceId);

            // get the collection of this AppPlatformGatewayRouteConfigResource
            AppPlatformGatewayRouteConfigCollection collection = appPlatformGateway.GetAppPlatformGatewayRouteConfigs();

            // invoke the operation
            string routeConfigName = "myRouteConfig";
            NullableResponse<AppPlatformGatewayRouteConfigResource> response = await collection.GetIfExistsAsync(routeConfigName);
            AppPlatformGatewayRouteConfigResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformGatewayRouteConfigData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
