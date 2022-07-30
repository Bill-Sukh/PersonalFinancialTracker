using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTracker
{
    [DataContract(Name = "Entry")]
    internal class Entry
    {
        [DataMember]
        private FamilyMember[] FamilyMember { get; set; }
        //public FamilyMember(string Name, Expense[] Expenses, byte PaydayInterval, byte LastPayday)
        //{
        //    this.Name = Name;
        //    this.Expenses = Expenses;
        //    this.PaydayInterval = PaydayInterval;
        //    this.LastPayday = LastPayday;
        //}
    }
}
