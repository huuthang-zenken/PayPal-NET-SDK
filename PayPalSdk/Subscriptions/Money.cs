using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class Money
    {
        public Money() {}

        [DataMember(Name="currency_code", EmitDefaultValue = false)]
        public string CurrencyCode;

        [DataMember(Name="value", EmitDefaultValue = false)]
        public string Value;
    }
}

