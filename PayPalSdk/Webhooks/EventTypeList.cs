using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class EventTypeList
    {
        public EventTypeList() { }

        [DataMember(Name = "event_types", EmitDefaultValue = false)]
        public List<EventType> EventTypes;
    }
}
