using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class AddressPortable
    {
        public AddressPortable() {}

        [DataMember(Name="address_details", EmitDefaultValue = false)]
        public AddressDetails AddressDetails;

        [DataMember(Name="address_line_1", EmitDefaultValue = false)]
        public string AddressLine1;

        [DataMember(Name="address_line_2", EmitDefaultValue = false)]
        public string AddressLine2;

        [DataMember(Name="address_line_3", EmitDefaultValue = false)]
        public string AddressLine3;

        [DataMember(Name="admin_area_1", EmitDefaultValue = false)]
        public string AdminArea1;

        [DataMember(Name="admin_area_2", EmitDefaultValue = false)]
        public string AdminArea2;

        [DataMember(Name="admin_area_3", EmitDefaultValue = false)]
        public string AdminArea3;

        [DataMember(Name="admin_area_4", EmitDefaultValue = false)]
        public string AdminArea4;

        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode;

        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode;
    }
}

