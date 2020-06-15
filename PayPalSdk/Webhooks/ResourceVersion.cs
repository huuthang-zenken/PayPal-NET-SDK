using System.Runtime.Serialization;

namespace PayPalSdk.Webhooks
{
    [DataContract]
    public class ResourceVersion
    {
        public ResourceVersion() { }

        [DataMember(Name = "resource_version", EmitDefaultValue = false)]
        public string ResourceVer;
    }
}
