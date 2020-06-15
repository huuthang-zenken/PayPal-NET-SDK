using PayPalHttp;
using System;
using System.IO;
using System.Net.Http;

namespace PayPalSdk.Webhooks
{
    public class WebhookGetEventSubscriptionsRequest : HttpRequest
    {
        public WebhookGetEventSubscriptionsRequest(string webhookId) : base("/v1/notifications/webhooks/{webhook_id}/event-types", HttpMethod.Get, typeof(EventTypeList))
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
