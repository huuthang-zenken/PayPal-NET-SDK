using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Subscriptions
{
    public class SubscriptionsCaptureRequest : HttpRequest
    {
        public SubscriptionsCaptureRequest(string subscriptionId) : base("/v1/billing/subscriptions/{id}/capture", HttpMethod.Post, typeof(CaptureSubscriptionResponse))
        {
            try
            {
                this.Path = this.Path.Replace("{id}", Uri.EscapeDataString(Convert.ToString(subscriptionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public SubscriptionsCaptureRequest RequestBody(CaptureSubscriptionRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
