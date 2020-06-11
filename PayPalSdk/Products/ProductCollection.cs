using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Products
{
    [DataContract]
    public class ProductCollection
    {
        public ProductCollection() {}

        [DataMember(Name = "total_items", EmitDefaultValue = false)]
        public string TotalItems;

        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public string TotalPages;

        [DataMember(Name = "products", EmitDefaultValue = false)]
        public List<ProductCollectionElement> Products;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
