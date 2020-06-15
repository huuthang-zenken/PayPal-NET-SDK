using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class SubscriberRequest
    {
        public SubscriberRequest() { }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Name Name;

        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string EmailAddress;

        [DataMember(Name = "payer_id", EmitDefaultValue = false)]
        public string PayerId;

        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public string ShippingAddress;

        [DataMember(Name = "payment_source", EmitDefaultValue = false)]
        public string PaymentSource;
    }
}
