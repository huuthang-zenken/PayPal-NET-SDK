using PayPalHttp;
using System;
using System.IO;
using System.Net.Http;

namespace PayPalSdk.Plans
{
    public class PlanUpdatePricingRequest : HttpRequest
    {
        public PlanUpdatePricingRequest(string planId) : base("/v1/billing/plans/{plan_id}/update-pricing-schemes", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(planId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public PlanUpdatePricingRequest RequestBody(UpdatePricingPlanRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
