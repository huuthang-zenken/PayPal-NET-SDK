using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class PaymentPreferences
    {
        public PaymentPreferences() {}

        [DataMember(Name = "auto_bill_outstanding", EmitDefaultValue = false)]
        public bool AutoBillOutstanding;

        [DataMember(Name = "setup_fee", EmitDefaultValue = false)]
        public Money SetupFee;

        /// <summary>
        /// The action to take on the subscription if the initial payment for the setup fails. The possible values are:
        /// CONTINUE: Continues the subscription if the initial payment for the setup fails.
        /// CANCEL: Cancels the subscription if the initial payment for the setup fails.
        /// </summary>
        [DataMember(Name = "setup_fee_failure_action", EmitDefaultValue = false)]
        public string SetupFeeFailureAction;

        [DataMember(Name = "payment_failure_threshold", EmitDefaultValue = false)]
        public int PaymentFailureThreshold;
    }
}
