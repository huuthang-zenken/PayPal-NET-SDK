using System.Runtime.Serialization;

namespace PayPalSdk.Products
{
    [DataContract]
    public class LinkDescription
    {
        public LinkDescription() {}

        [DataMember(Name="encType", EmitDefaultValue = false)]
        public string EncType;

        [DataMember(Name="href", EmitDefaultValue = false)]
        public string Href;

        [DataMember(Name="mediaType", EmitDefaultValue = false)]
        public string MediaType;

        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method;

        [DataMember(Name="rel", EmitDefaultValue = false)]
        public string Rel;

        [DataMember(Name="title", EmitDefaultValue = false)]
        public string Title;
    }
}

