using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Error
{
    [DataContract]
    public class Error
    {
        public Error() {}

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message;

        [DataMember(Name = "debug_id", EmitDefaultValue = false)]
        public string DebugId;

        [DataMember(Name = "information_link", EmitDefaultValue = false)]
        public string InformationLink;

        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<ErrorDetails> Details;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
