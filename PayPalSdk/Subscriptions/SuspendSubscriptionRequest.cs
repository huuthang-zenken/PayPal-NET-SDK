using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class SuspendSubscriptionRequest
    {
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason;
    }
}
