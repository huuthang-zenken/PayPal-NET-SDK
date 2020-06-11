using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class ReviseSubscriptionRequest
    {
        public ReviseSubscriptionRequest() {}

        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId;

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity;

        [DataMember(Name = "shipping_amount", EmitDefaultValue = false)]
        public Money ShippingAmount;

        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public ShippingDetail ShippingAddress;

        [DataMember(Name = "application_context", EmitDefaultValue = false)]
        public ApplicationContext ApplicationContext;
    }
}
