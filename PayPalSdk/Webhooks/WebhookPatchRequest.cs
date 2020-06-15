using PayPalHttp;
using PayPalSdk.Plans;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace PayPalSdk.Webhooks
{
    public class WebhookPatchRequest<T> : HttpRequest
    {
        public WebhookPatchRequest(string webhookId) : base("/v1/notifications/webhooks/{webhook_id}", HttpMethod.Patch, typeof(Webhook))
        {
            try
            {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(webhookId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public WebhookPatchRequest<T> RequestBody(List<Patch<T>> patchRequest)
        {
            this.Body = patchRequest;
            return this;
        }
    }
}
