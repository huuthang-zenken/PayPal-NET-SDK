using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class PaymentDefinition
    {
        public PaymentDefinition() {}

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// Possible values: TRIAL, REGULAR.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type;
        
        [DataMember(Name = "frequency_interval", EmitDefaultValue = false)]
        public string FrequencyInterval;

        /// <summary>
        /// Possible values: WEEK, DAY, YEAR, MONTH.
        /// </summary>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public string Frequency;

        [DataMember(Name = "cycles", EmitDefaultValue = false)]
        public string Cycles;
    }
}
