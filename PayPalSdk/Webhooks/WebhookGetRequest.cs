using PayPalHttp;
using System;
using System.IO;
using System.Net.Http;

namespace PayPalSdk.Webhooks
{
    public class WebhookGetRequest : HttpRequest
    {
        public WebhookGetRequest() : base("/v1/notifications/webhooks", HttpMethod.Get, typeof(WebhookList))
        {
            this.ContentType = "application/json";
        }

        public WebhookGetRequest(string webhookId) : base("/v1/notifications/webhooks/{webhook_id}", HttpMethod.Get, typeof(Webhook))
        {
            try
            {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(webhookId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
    }
}
