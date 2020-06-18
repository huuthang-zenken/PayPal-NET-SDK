using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class BillingCycles
    {
        public BillingCycles() {}

        [DataMember(Name = "pricing_scheme", EmitDefaultValue = false)]
        public PricingScheme PricingScheme;

        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public Frequency Frequency;

        /// <summary>
        /// The tenure type of the billing cycle. In case of a plan having trial cycle, only 2 trial cycles are allowed per plan. The possible values are:
        /// REGULAR: A regular billing cycle.
        /// TRIAL: A trial billing cycle.
        /// </summary>
        [DataMember(Name = "tenure_type", EmitDefaultValue = false)]
        public string TenureType;

        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public int Sequence;

        [DataMember(Name = "total_cycles", EmitDefaultValue = false)]
        public int TotalCycles;
    }
}
