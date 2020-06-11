using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class AddressDetails
    {
        public AddressDetails() {}

        [DataMember(Name="building_name", EmitDefaultValue = false)]
        public string BuildingName;

        [DataMember(Name="delivery_service", EmitDefaultValue = false)]
        public string DeliveryService;

        [DataMember(Name="street_name", EmitDefaultValue = false)]
        public string StreetName;

        [DataMember(Name="street_number", EmitDefaultValue = false)]
        public string StreetNumber;

        [DataMember(Name="street_type", EmitDefaultValue = false)]
        public string StreetType;

        [DataMember(Name="sub_building", EmitDefaultValue = false)]
        public string SubBuilding;
    }
}

