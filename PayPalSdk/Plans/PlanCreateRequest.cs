using PayPalHttp;
using System.Net.Http;

namespace PayPalSdk.Plans
{
    public class PlanCreateRequest : HttpRequest
    {
        public PlanCreateRequest() : base("/v1/billing/plans", HttpMethod.Post, typeof(Plan))
        {
            this.ContentType = "application/json";
        }

        public PlanCreateRequest Prefer(string prefer)
        {
            this.Headers.Add("Prefer", prefer);
            return this;
        }

        public PlanCreateRequest RequestBody(PlanRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
