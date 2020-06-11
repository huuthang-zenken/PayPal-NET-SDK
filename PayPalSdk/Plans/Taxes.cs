using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class Taxes
    {
        public Taxes() { }

        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public string Percentage;

        [DataMember(Name = "inclusive", EmitDefaultValue = false)]
        public bool Inclusive;
    }
}
