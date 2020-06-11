using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Plans
{
    public class PlansGetRequest : HttpRequest
    {
        public PlansGetRequest(int page, int pageSize) : base("/v1/billing/plans?page={page}&page_size={page_size}&total_required=true", HttpMethod.Get, typeof(PlanCollection))
        {
            try
            {
                this.Path = this.Path.Replace("{page}", Uri.EscapeDataString(Convert.ToString(page)));
                this.Path = this.Path.Replace("{page_size}", Uri.EscapeDataString(Convert.ToString(pageSize)));

            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public PlansGetRequest(int productId, int page, int pageSize) : base("/v1/billing/plans?product_id={product_id}&page={page}&page_size={page_size}&total_required=true", HttpMethod.Get, typeof(PlanCollection))
        {
            try
            {
                this.Path = this.Path.Replace("{product_id}", Uri.EscapeDataString(Convert.ToString(productId)));
                this.Path = this.Path.Replace("{page}", Uri.EscapeDataString(Convert.ToString(page)));
                this.Path = this.Path.Replace("{page_size}", Uri.EscapeDataString(Convert.ToString(pageSize)));

            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public PlansGetRequest(string planId) : base("/v1/billing/plans/{plan_id}", HttpMethod.Get, typeof(Plan))
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
