using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class LastPaymentDetails
    {
        public LastPaymentDetails() {}

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount;

        [DataMember(Name = "time", EmitDefaultValue = false)]
        public string Time;
    }
}
