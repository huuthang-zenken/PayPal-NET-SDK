using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class PricingScheme
    {
        public PricingScheme() {}

        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int Version;

        [DataMember(Name = "fixed_price", EmitDefaultValue = false)]
        public Money FixedPrice;

        [DataMember(Name = "create_time ", EmitDefaultValue = false)]
        public string CreateTime;

        [DataMember(Name = "update_time ", EmitDefaultValue = false)]
        public string UpdateTime;
    }
}
