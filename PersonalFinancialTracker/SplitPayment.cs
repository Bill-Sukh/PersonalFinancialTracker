using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTracker
{
    [DataContract(Name = "SplitPayments")]
    internal class SplitPayment
    {
        [DataMember]
        public byte ExpenseUID { get; set; }
        [DataMember]
        public decimal SplitPaymentAmount { get; set; }

    }
}
