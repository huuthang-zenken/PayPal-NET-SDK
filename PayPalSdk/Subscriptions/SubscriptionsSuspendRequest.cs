using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Subscriptions
{
    public class SubscriptionsSuspendRequest : HttpRequest
    {
        public SubscriptionsSuspendRequest(string subscriptionId) : base("/v1/billing/subscriptions/{id}/suspend", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{id}", Uri.EscapeDataString(Convert.ToString(subscriptionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public SubscriptionsSuspendRequest RequestBody(SuspendSubscriptionRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
