using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class SuspendSubscriptionRequest
    {
        public SuspendSubscriptionRequest() { }

        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason;
    }
}
