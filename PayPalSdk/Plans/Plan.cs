using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class Plan
    {
        public Plan() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "product_id", EmitDefaultValue = false)]
        public string ProductId;

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// The plan status. The possible values are:
        /// CREATED: The plan was created. You cannot create subscriptions for a plan in this state.
        /// INACTIVE: The plan is inactive.
        /// ACTIVE: The plan is active. You can only create subscriptions for a plan in this state.
               /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status;

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description;

        [DataMember(Name = "billing_cycles", EmitDefaultValue = false)]
        public BillingCycles BillingCycles;

        [DataMember(Name = "payment_preferences", EmitDefaultValue = false)]
        public PaymentPreferences PaymentPreferences;

        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public Taxes Taxes;

        [DataMember(Name = "quantity_supported", EmitDefaultValue = false)]
        public bool QuantitySupported;

        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime;

        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
