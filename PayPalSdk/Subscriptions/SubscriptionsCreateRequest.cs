using PayPalHttp;
using System.Net.Http;

namespace PayPalSdk.Subscriptions
{
    public class SubscriptionsCreateRequest : HttpRequest
    {
        public SubscriptionsCreateRequest() : base("/v1/billing/subscriptions", HttpMethod.Post, typeof(Subscription))
        {
            this.ContentType = "application/json";
        }

        public SubscriptionsCreateRequest Prefer(string prefer)
        {
            this.Headers.Add("Prefer", prefer);
            return this;
        }

        public SubscriptionsCreateRequest RequestBody(SubscriptionRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
