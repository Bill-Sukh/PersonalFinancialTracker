using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PersonalFinancialTracker
{
    [DataContract(Name = "Expense")]
    internal class Expense
    {

        [DataMember]
        public byte ExpenseUID { get; set; }

        [DataMember]
        public string PaymentReceiver { get; set; }

        [DataMember]
        public string ExpenseCategory { get; set; }

        [DataMember]
        public string ExpenseName { get; set; }

        [DataMember]
        public byte PromisedDue { get; set; }

        [DataMember]
        public byte ActualDue { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

    }
}
