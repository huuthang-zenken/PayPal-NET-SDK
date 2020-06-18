using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Plans
{
    public class PlanListRequest : HttpRequest
    {
        public PlanListRequest() : base("/v1/billing/plans?", HttpMethod.Get, typeof(PlanCollection))
        {
            this.ContentType = "application/json";
        }

        public PlanListRequest Page(int page)
        {
            var strParams = Convert.ToString(page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }

            return this;
        }

        public PlanListRequest PageSize(int pageSize)
        {
            var strParams = Convert.ToString(pageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }

            return this;
        }

        public PlanListRequest TotalRequired(bool totalRequired)
        {
            var strParams = Convert.ToString(totalRequired);
            try
            {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }

            return this;
        }

        public PlanListRequest ProductId(string productId)
        {
            var strParams = Convert.ToString(productId);
            try
            {
                this.Path = $"{this.Path}product_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }

            return this;
        }
    }
}
