using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class CycleExecutions
    {
        public CycleExecutions() {}

        /// <summary>
        /// The type of the billing cycle. The possible values are:
        /// REGULAR: A regular billing cycle.
        /// TRIAL: A trial billing cycle.
        /// </summary>
        [DataMember(Name = "tenure_type", EmitDefaultValue = false)]
        public string TenureType;

        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public int Sequence;

        [DataMember(Name = "cycles_completed", EmitDefaultValue = false)]
        public int CyclesCompleted;

        [DataMember(Name = "cycles_remaining", EmitDefaultValue = false)]
        public int CyclesRemaining;

        [DataMember(Name = "total_cycles", EmitDefaultValue = false)]
        public int TotalCycles;

        [DataMember(Name = "current_pricing_scheme_version", EmitDefaultValue = false)]
        public int CurrentPricingSchemeVersion;
    }
}
