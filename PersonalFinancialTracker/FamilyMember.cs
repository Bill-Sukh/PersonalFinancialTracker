using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTracker
{
    [DataContract(Name = "FamilyMember")]
    internal class FamilyMember
    {
        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public int[]? ExpenseUIDs { get; set; }

        [DataMember]
        public byte PaydayInterval { get; set; }

        [DataMember]
        public byte LastPayday { get; set; }

        [DataMember]
        public SplitPayment[] SplitPayments { get; set; }

    }
}
