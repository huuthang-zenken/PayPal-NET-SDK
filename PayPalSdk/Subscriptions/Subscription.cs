using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class Subscription
    {
        public Subscription() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// The status of the subscription. The possible values are:
        /// APPROVAL_PENDING: The subscription is created but not yet approved by the buyer.
        /// APPROVED: The buyer has approved the subscription.
        /// ACTIVE: The subscription is active.
        /// SUSPENDED: The subscription is suspended.
        /// CANCELLED: The subscription is cancelled.
        /// EXPIRED: The subscription is expired.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status;

        [DataMember(Name = "status_change_note", EmitDefaultValue = false)]
        public string StatusChangeNote;

        [DataMember(Name = "status_update_time", EmitDefaultValue = false)]
        public string StatusUpdateTime;

        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId;

        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime;

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity;

        [DataMember(Name = "shipping_amount", EmitDefaultValue = false)]
        public Money ShippingAmount;

        [DataMember(Name = "subscriber", EmitDefaultValue = false)]
        public Subscriber Subscriber;

        [DataMember(Name = "billing_info", EmitDefaultValue = false)]
        public BillingInfo BillingInfo;

        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime;

        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
