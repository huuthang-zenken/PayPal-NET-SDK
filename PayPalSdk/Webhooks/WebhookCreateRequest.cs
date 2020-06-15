using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Webhooks
{
    public class WebhookCreateRequest : HttpRequest
    {
        public WebhookCreateRequest() : base("/v1/notifications/webhooks", HttpMethod.Post, typeof(Webhook))
        {
            this.ContentType = "application/json";
        }

        public WebhookCreateRequest RequestBody(WebhookRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
