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
        private string ExpenseName { get; set; }
        [DataMember]
        private string PromisedDue { get; set; }
        [DataMember]
        private string ActualDue { get; set; }
        [DataMember]
        private string Amount { get; set; }

        //public Expense(string ExpenseName,  string PromisedDue, string ActualDue, string Amount)
        //{
        //    this.ExpenseName = ExpenseName;
        //    this.PromisedDue = PromisedDue;
        //    this.ActualDue = ActualDue;
        //    this.Amount = Amount;
        //}
        
    }
}
