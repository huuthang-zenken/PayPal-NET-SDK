using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Products
{
    public class ProductsGetRequest : HttpRequest
    {
        public ProductsGetRequest(int page, int pageSize) : base("/v1/catalogs/products?page={page}&page_size={page_size}&total_required=true", HttpMethod.Get, typeof(ProductCollection))
        {
            try
            {
                this.Path = this.Path.Replace("{page}", Uri.EscapeDataString(Convert.ToString(page)));
                this.Path = this.Path.Replace("{page_size}", Uri.EscapeDataString(Convert.ToString(pageSize)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public ProductsGetRequest(string productId) : base("/v1/catalogs/products/{product_id}", HttpMethod.Get, typeof(Product))
        {
            try
            {
                this.Path = this.Path.Replace("{product_id}", Uri.EscapeDataString(Convert.ToString(productId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
