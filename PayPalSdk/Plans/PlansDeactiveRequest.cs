using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Plans
{
    public class PlansDeactiveRequest<T> : HttpRequest
    {
        public PlansDeactiveRequest(string planId) : base("/v1/billing/plans/{plan_id}/deactivate", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(planId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
    }
}
