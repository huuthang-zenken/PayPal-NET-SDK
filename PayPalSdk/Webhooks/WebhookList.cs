using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class WebhookList
    {
        public WebhookList() { }

        [DataMember(Name = "webhooks", EmitDefaultValue = false)]
        public List<Webhook> Webhooks;
    }
}
