using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class SubscriptionRequest
    {
        public SubscriptionRequest() {}

        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId;

        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime;

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity;

        [DataMember(Name = "shipping_amount", EmitDefaultValue = false)]
        public Money ShippingAmount;

        [DataMember(Name = "subscriber", EmitDefaultValue = false)]
        public SubscriberRequest Subscriber;

        [DataMember(Name = "auto_renewal", EmitDefaultValue = false)]
        public bool AutoRenewal;

        [DataMember(Name = "application_context", EmitDefaultValue = false)]
        public ApplicationContext ApplicationContext;
    }
}
