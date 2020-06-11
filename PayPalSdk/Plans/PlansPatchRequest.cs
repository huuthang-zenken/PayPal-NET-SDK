using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Plans
{
    public class PlansPatchRequest<T> : HttpRequest
    {
        public PlansPatchRequest(string planId) : base("/v1/billing/plans/{plan_id}", HttpMethod.Patch, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(planId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public PlansPatchRequest<T> RequestBody(List<Patch<T>> patchRequest)
        {
            this.Body = patchRequest;
            return this;
        }
    }
}
