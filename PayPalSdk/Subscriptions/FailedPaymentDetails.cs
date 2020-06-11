using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class FailedPaymentDetails
    {
        public FailedPaymentDetails() { }

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount;

        [DataMember(Name = "time", EmitDefaultValue = false)]
        public string Time;

        /// <summary>
        /// The reason code for the payment failure. The possible values are:
        /// PAYMENT_DENIED: PayPal declined the payment due to one or more customer issues.
        /// INTERNAL_SERVER_ERROR: An internal server error has occurred.
        /// PAYEE_ACCOUNT_RESTRICTED: The payee account is not in good standing and cannot receive payments.
        /// PAYER_ACCOUNT_RESTRICTED: The payer account is not in good standing and cannot make payments.
        /// PAYER_CANNOT_PAY: Payer cannot pay for this transaction.
        /// SENDING_LIMIT_EXCEEDED: The transaction exceeds the payer's sending limit.
        /// TRANSACTION_RECEIVING_LIMIT_EXCEEDED: The transaction exceeds the receiver's receiving limit.
        /// CURRENCY_MISMATCH: The transaction is declined due to a currency mismatch.
        /// </summary>
        [DataMember(Name = "reason_code", EmitDefaultValue = false)]
        public string ReasonCode;

        [DataMember(Name = "next_payment_retry_time", EmitDefaultValue = false)]
        public string NextPaymentRetryTime;
    }
}
