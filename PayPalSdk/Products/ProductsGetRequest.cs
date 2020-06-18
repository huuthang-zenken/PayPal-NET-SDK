using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Products
{
    public class ProductsGetRequest : HttpRequest
    {
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
