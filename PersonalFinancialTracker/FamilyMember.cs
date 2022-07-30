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
        private string Name { get; set; }
        [DataMember]
        private int[] Expenses { get; set; }
        [DataMember]
        private byte PaydayInterval { get; set; }
        [DataMember]
        private byte LastPayday { get; set; }

        //public FamilyMember(string Name, Expense[] Expenses, byte PaydayInterval, byte LastPayday)
        //{
        //    this.Name = Name;
        //    this.Expenses = Expenses;
        //    this.PaydayInterval = PaydayInterval;
        //    this.LastPayday = LastPayday;
        //}
    }
}
