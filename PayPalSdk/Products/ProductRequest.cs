using System.Runtime.Serialization;

namespace PayPalSdk.Products
{
    [DataContract]
    public class ProductRequest
    {
        public ProductRequest() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// The product type. Indicates whether the product is physical or tangible goods, or a service. The allowed values are:
        /// PHYSICAL: Physical goods.
        /// DIGITAL: Digital goods.
        /// SERVICE: A service. For example, technical support.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type;

        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category;

        [DataMember(Name = "image_url", EmitDefaultValue = false)]
        public string ImageUrl;

        [DataMember(Name = "home_url", EmitDefaultValue = false)]
        public string HomeUrl;
    }
}
