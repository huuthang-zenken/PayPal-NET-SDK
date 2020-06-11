using PayPalHttp;
using System.Net.Http;

namespace PayPalSdk.Plans
{
    public class PlansCreateRequest : HttpRequest
    {
        public PlansCreateRequest() : base("/v1/billing/plans", HttpMethod.Post, typeof(Plan))
        {
            this.ContentType = "application/json";
        }

        public PlansCreateRequest Prefer(string prefer)
        {
            this.Headers.Add("Prefer", prefer);
            return this;
        }

        public PlansCreateRequest RequestBody(PlanRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
