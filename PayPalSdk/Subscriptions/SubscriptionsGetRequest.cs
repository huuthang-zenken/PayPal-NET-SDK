using PayPalHttp;
using System;
using System.IO;
using System.Net.Http;

namespace PayPalSdk.Subscriptions
{
    public class SubscriptionsGetRequest : HttpRequest
    {
        public SubscriptionsGetRequest(string subscriptionId) : base("/v1/billing/subscriptions/{id}", HttpMethod.Get, typeof(Subscription))
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
