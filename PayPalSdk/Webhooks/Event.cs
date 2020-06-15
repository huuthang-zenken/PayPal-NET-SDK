using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class Event
    {
        public Event() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime;

        [DataMember(Name = "resource_type", EmitDefaultValue = false)]
        public string ResourceType;

        [DataMember(Name = "event_version", EmitDefaultValue = false)]
        public string EventVersion;

        [DataMember(Name = "event_type", EmitDefaultValue = false)]
        public string EventType;

        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary;

        [DataMember(Name = "resource_version", EmitDefaultValue = false)]
        public string ResourceVersion;

        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public object Resource;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
