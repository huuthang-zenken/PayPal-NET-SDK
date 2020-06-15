using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Subscriptions
{
    [DataContract]
    public class TransactionCollection
    {
        public TransactionCollection() { }

        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<Transaction> Transactions;

        [DataMember(Name = "total_items", EmitDefaultValue = false)]
        public int TotalItems;

        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages;

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
