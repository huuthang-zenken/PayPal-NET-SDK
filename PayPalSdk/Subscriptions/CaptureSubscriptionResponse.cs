using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class CaptureSubscriptionResponse
    {
        public CaptureSubscriptionResponse() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// The status of the captured payment. The possible values are:
        /// COMPLETED: The funds for this captured payment were credited to the payee's PayPal account.
        /// DECLINED: The funds could not be captured.
        /// PARTIALLY_REFUNDED: An amount less than this captured payment's amount was partially refunded to the payer.
        /// PENDING: The funds for this captured payment was not yet credited to the payee's PayPal account. For more information, see status.details.
        /// REFUNDED: An amount greater than or equal to this captured payment's amount was refunded to the payer.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status;

        [DataMember(Name = "amount_with_breakdown", EmitDefaultValue = false)]
        public AmountWithBreakdown AmountWithBreakdown;

        [DataMember(Name = "payer_name", EmitDefaultValue = false)]
        public Name PayerName;

        [DataMember(Name = "payer_email", EmitDefaultValue = false)]
        public string PayerEmail;

        [DataMember(Name = "time", EmitDefaultValue = false)]
        public string Time;
    }
}
