// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ResourceHealth.Samples
{
    public partial class Sample_ResourceHealthEventResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SecurityAdvisoriesEventBySubscriptionIdAndTrackingId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2023-10-01-preview/examples/Event_GetBySubscriptionIdAndTrackingId.json
            // this example is just showing the usage of "Event_GetBySubscriptionIdAndTrackingId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceHealthEventResource created on azure
            // for more information of creating ResourceHealthEventResource, please refer to the document of ResourceHealthEventResource
            string subscriptionId = "subscriptionId";
            string eventTrackingId = "eventTrackingId";
            ResourceIdentifier resourceHealthEventResourceId = ResourceHealthEventResource.CreateResourceIdentifier(subscriptionId, eventTrackingId);
            ResourceHealthEventResource resourceHealthEvent = client.GetResourceHealthEventResource(resourceHealthEventResourceId);

            // invoke the operation
            string filter = "properties/status eq 'Active'";
            string queryStartTime = "7/10/2022";
            ResourceHealthEventResource result = await resourceHealthEvent.GetAsync(filter: filter, queryStartTime: queryStartTime);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceHealthEventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventId_ListSecurityAdvisoryImpactedResourcesBySubscriptionId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2023-10-01-preview/examples/SecurityAdvisoryImpactedResources_ListBySubscriptionId_ListByEventId.json
            // this example is just showing the usage of "SecurityAdvisoryImpactedResources_ListBySubscriptionIdAndEventId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceHealthEventResource created on azure
            // for more information of creating ResourceHealthEventResource, please refer to the document of ResourceHealthEventResource
            string subscriptionId = "subscriptionId";
            string eventTrackingId = "BC_1-FXZ";
            ResourceIdentifier resourceHealthEventResourceId = ResourceHealthEventResource.CreateResourceIdentifier(subscriptionId, eventTrackingId);
            ResourceHealthEventResource resourceHealthEvent = client.GetResourceHealthEventResource(resourceHealthEventResourceId);

            // invoke the operation and iterate over the result
            await foreach (ResourceHealthEventImpactedResourceData item in resourceHealthEvent.GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventIdAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task FetchDetailsBySubscriptionIdAndTrackingId_EventDetailsBySubscriptionIdAndTrackingId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2023-10-01-preview/examples/Event_fetchDetailsBySubscriptionIdAndTrackingId.json
            // this example is just showing the usage of "Event_FetchDetailsBySubscriptionIdAndTrackingId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceHealthEventResource created on azure
            // for more information of creating ResourceHealthEventResource, please refer to the document of ResourceHealthEventResource
            string subscriptionId = "subscriptionId";
            string eventTrackingId = "eventTrackingId";
            ResourceIdentifier resourceHealthEventResourceId = ResourceHealthEventResource.CreateResourceIdentifier(subscriptionId, eventTrackingId);
            ResourceHealthEventResource resourceHealthEvent = client.GetResourceHealthEventResource(resourceHealthEventResourceId);

            // invoke the operation
            ResourceHealthEventResource result = await resourceHealthEvent.FetchDetailsBySubscriptionIdAndTrackingIdAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceHealthEventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
