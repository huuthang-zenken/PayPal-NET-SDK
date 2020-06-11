using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class ShippingDetail
    {
        public ShippingDetail() {}

        [DataMember(Name="address", EmitDefaultValue = false)]
        public AddressPortable AddressPortable;

        [DataMember(Name="name", EmitDefaultValue = false)]
        public Name Name;

        [DataMember(Name="options", EmitDefaultValue = false)]
        public List<ShippingOption> Options;
    }
}

