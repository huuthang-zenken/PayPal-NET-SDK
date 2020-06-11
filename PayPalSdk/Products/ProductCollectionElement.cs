using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Products
{
    [DataContract]
    public class ProductCollectionElement
    {
        public ProductCollectionElement() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description;

        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
