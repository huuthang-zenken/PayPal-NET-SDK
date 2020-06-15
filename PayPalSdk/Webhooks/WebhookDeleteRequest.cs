using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Webhooks
{
    public class WebhookDeleteRequest : HttpRequest
    {
        public WebhookDeleteRequest(string webhookId) : base("/v1/notifications/webhooks/{webhook_id}", HttpMethod.Delete, typeof(void))
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
