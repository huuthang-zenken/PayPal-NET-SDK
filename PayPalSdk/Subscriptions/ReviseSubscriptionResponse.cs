using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class ReviseSubscriptionResponse
    {
        public ReviseSubscriptionResponse() {}

        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId;

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity;

        [DataMember(Name = "effective_time", EmitDefaultValue = false)]
        public string EffectiveTime;

        [DataMember(Name = "shipping_amount", EmitDefaultValue = false)]
        public Money ShippingAmount;

        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public ShippingDetail ShippingAddress;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
