using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Products
{
    public class ProductsListRequest : HttpRequest
    {
        public ProductsListRequest() : base("/v1/catalogs/products?", HttpMethod.Get, typeof(ProductCollection))
        {
            this.ContentType = "application/json";
        }

        public ProductsListRequest Page(int page)
        {
            var strParams = Convert.ToString(page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }

            return this;
        }

        public ProductsListRequest PageSize(int pageSize)
        {
            var strParams = Convert.ToString(pageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }

            return this;
        }

        public ProductsListRequest TotalRequired(bool totalRequired)
        {
            var strParams = Convert.ToString(totalRequired);
            try
            {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }

            return this;
        }
    }
}
