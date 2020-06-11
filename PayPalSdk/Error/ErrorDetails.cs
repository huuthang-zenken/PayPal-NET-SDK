using System.Runtime.Serialization;

namespace PayPalSdk.Error
{
    [DataContract]
    public class ErrorDetails
    {
        public ErrorDetails() { }

        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field;

        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value;

        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location;

        [DataMember(Name = "issue", EmitDefaultValue = false)]
        public string Issue;

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description;
    }
}
