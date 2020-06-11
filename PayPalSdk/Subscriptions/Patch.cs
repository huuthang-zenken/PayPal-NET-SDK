using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class Patch<T>
    {
        public Patch() {}

        [DataMember(Name="from", EmitDefaultValue = false)]
        public string From;

        [DataMember(Name="op", EmitDefaultValue = false)]
        public string Op;

        [DataMember(Name="path", EmitDefaultValue = false)]
        public string Path;

        [DataMember(Name="value", EmitDefaultValue = false)]
        public T Value;
    }
}

