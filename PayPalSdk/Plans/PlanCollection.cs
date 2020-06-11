using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class PlanCollection
    {
        public PlanCollection() {}

        [DataMember(Name = "total_items", EmitDefaultValue = false)]
        public string TotalItems;

        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public string TotalPages;

        [DataMember(Name = "plans", EmitDefaultValue = false)]
        public List<Plan> Plans { get; set; }

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
