using System.Runtime.Serialization;

namespace PayPalSdk.Plans
{
    [DataContract]
    public class Frequency
    {
        public Frequency() {}

        /// <summary>
        /// The interval at which the subscription is charged or billed. The possible values are:
        /// DAY. A daily billing cycle.
        /// WEEK. A weekly billing cycle.
        /// MONTH. A monthly billing cycle.
        /// YEAR. A yearly billing cycle.
        /// </summary>
        [DataMember(Name = "interval_unit", EmitDefaultValue = false)]
        public string IntervalUnit;

        [DataMember(Name = "interval_count", EmitDefaultValue = false)]
        public string IntervalCount;
    }
}
