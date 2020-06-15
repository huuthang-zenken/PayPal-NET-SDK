using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class BillingInfo
    {
        public BillingInfo() {}

        [DataMember(Name = "outstanding_balance", EmitDefaultValue = false)]
        public Money OutstandingBalance;

        [DataMember(Name = "cycle_executions", EmitDefaultValue = false)]
        public List<CycleExecutions> CycleExecutions;

        [DataMember(Name = "last_payment", EmitDefaultValue = false)]
        public LastPaymentDetails LastPayment;

        [DataMember(Name = "next_billing_time", EmitDefaultValue = false)]
        public string NextBillingTime;

        [DataMember(Name = "final_payment_time", EmitDefaultValue = false)]
        public string FinalPaymentTime;

        [DataMember(Name = "failed_payments_count", EmitDefaultValue = false)]
        public int FailedPaymentsCount;

        [DataMember(Name = "last_failed_payment", EmitDefaultValue = false)]
        public FailedPaymentDetails LastFailedPayment;
    }
}
