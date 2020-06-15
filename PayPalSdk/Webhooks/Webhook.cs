using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class Webhook
    {
        public Webhook() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url;

        [DataMember(Name = "event_types", EmitDefaultValue = false)]
        public List<EventType> EventTypes;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
