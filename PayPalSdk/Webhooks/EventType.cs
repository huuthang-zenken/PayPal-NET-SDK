using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class EventType
    {
        public EventType() { }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description;

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status;

        [DataMember(Name = "resource_versions", EmitDefaultValue = false)]
        public List<ResourceVersion> ResourceVersions { get; set; }
    }
}
