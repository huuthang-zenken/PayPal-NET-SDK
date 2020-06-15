using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class EventList
    {
        public EventList() { }

        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<Event> Events;

        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
