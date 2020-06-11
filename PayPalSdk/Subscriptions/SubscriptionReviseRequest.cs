using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Subscriptions
{
    public class SubscriptionReviseRequest : HttpRequest
    {
        public SubscriptionReviseRequest(string subscriptionId) : base("/v1/billing/subscriptions/{id}/revise", HttpMethod.Post, typeof(ReviseSubscriptionResponse))
        {
            try
            {
                this.Path = this.Path.Replace("{id}", Uri.EscapeDataString(Convert.ToString(subscriptionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public SubscriptionReviseRequest RequestBody(ReviseSubscriptionRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
