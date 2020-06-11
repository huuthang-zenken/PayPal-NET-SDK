using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class CaptureSubscriptionRequest
    {
        public CaptureSubscriptionRequest() {}

        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note;

        /// <summary>
        /// The type of capture. The allowed values are:
        /// OUTSTANDING_BALANCE: The outstanding balance that the subscriber must clear.
        /// </summary>
        [DataMember(Name = "capture_type", EmitDefaultValue = false)]
        public string CaptureType;

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount;
    }
}
