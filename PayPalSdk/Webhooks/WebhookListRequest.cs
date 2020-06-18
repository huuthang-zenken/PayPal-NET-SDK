using PayPalHttp;
using System.Net.Http;

namespace PayPalSdk.Webhooks
{
    public class WebhookListRequest : HttpRequest
    {
        public WebhookListRequest() : base("/v1/notifications/webhooks", HttpMethod.Get, typeof(WebhookList))
        {
            this.ContentType = "application/json";
        }
    }
}
