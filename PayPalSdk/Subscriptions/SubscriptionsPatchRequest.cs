using System;
using System.Collections.Generic;
using System.IO;

using PayPalHttp;
using System.Net.Http;

namespace PayPalSdk.Subscriptions
{
    public class SubscriptionsPatchRequest<T> : HttpRequest
    {
        public SubscriptionsPatchRequest(string subscriptionId) : base("/v1/billing/subscriptions/{id}", HttpMethod.Patch, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{id}", Uri.EscapeDataString(Convert.ToString(subscriptionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public SubscriptionsPatchRequest<T> RequestBody(List<Patch<T>> patchRequest)
        {
            this.Body = patchRequest;
            return this;
        }
    }
}
