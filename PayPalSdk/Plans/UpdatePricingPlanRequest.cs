using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class UpdatePricingPlanRequest
    {
        public UpdatePricingPlanRequest() { }

        [DataMember(Name = "pricing_schemes", EmitDefaultValue = false)]
        public PricingScheme PricingSchemes;
    }
}
