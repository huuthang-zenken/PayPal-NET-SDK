using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Products
{
    [DataContract]
    public class Product
    {
        public Product() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// The product type. Indicates whether the product is physical or digital goods, or a service. The possible values are:
        /// PHYSICAL: Physical goods
        /// DIGITAL: Digital goods
        /// SERVICE: Product representing a service. Example: Tech Support
        /// Default: PHYSICAL.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type;

        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category;

        [DataMember(Name = "image_url", EmitDefaultValue = false)]
        public string ImageUrl;

        [DataMember(Name = "home_url", EmitDefaultValue = false)]
        public string HomeUrl;

        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime;

        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
