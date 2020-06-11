using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Products
{
    public class ProductsPatchRequest<T> : HttpRequest
    {
        public ProductsPatchRequest(string productId) : base("/v1/catalogs/products/{product_id}", HttpMethod.Patch, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{product_id}", Uri.EscapeDataString(Convert.ToString(productId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public ProductsPatchRequest<T> RequestBody(List<Patch<T>> patchRequest)
        {
            this.Body = patchRequest;
            return this;
        }
    }
}
