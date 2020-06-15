using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class ShippingAddress
    {
        public ShippingAddress() { }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Name Name;

        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressPortable Address;
    }
}
