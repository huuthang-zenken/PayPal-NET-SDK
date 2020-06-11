using PayPalHttp;
using System.Net.Http;

namespace PayPalSdk.Products
{
    public class ProductsCreateRequest : HttpRequest
    {
        public ProductsCreateRequest() : base("/v1/catalogs/products", HttpMethod.Post, typeof(Product))
        {
            this.ContentType = "application/json";
        }

        public ProductsCreateRequest Prefer(string prefer)
        {
            this.Headers.Add("Prefer", prefer);
            return this;
        }

        public ProductsCreateRequest RequestBody(ProductRequest request)
        {
            this.Body = request;
            return this;
        }
    }
}
