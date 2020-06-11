using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Subscriptions
{
    public class SubscriptionsCancelRequest : HttpRequest
    {
        public SubscriptionsCancelRequest(string subscriptionId) : base("/v1/billing/subscriptions/{id}/cancel", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{id}", Uri.EscapeDataString(Convert.ToString(subscriptionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
    }
}
