using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class WebhookRequest
    {
        public WebhookRequest() {}

        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url;

        [DataMember(Name = "event_types", EmitDefaultValue = false)]
        public List<EventType> EventTypes;
    }
}
