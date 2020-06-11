using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class Name
    {
        public Name() {}

        [DataMember(Name="alternate_full_name", EmitDefaultValue = false)]
        public string AlternateFullName;

        [DataMember(Name="full_name", EmitDefaultValue = false)]
        public string FullName;

        [DataMember(Name="given_name", EmitDefaultValue = false)]
        public string GivenName;

        [DataMember(Name="middle_name", EmitDefaultValue = false)]
        public string MiddleName;

        [DataMember(Name="prefix", EmitDefaultValue = false)]
        public string Prefix;

        [DataMember(Name="suffix", EmitDefaultValue = false)]
        public string Suffix;

        [DataMember(Name="surname", EmitDefaultValue = false)]
        public string Surname;
    }
}

