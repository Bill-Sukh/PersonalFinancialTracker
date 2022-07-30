using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTracker
{
    internal class Expense
    {
        private string ExpenseName { get; }
        private string PromisedDue { get; }
        private string ActualDue { get; }
        private string Amount { get; }

        public Expense(string ExpenseName,  string PromisedDue, string ActualDue, string Amount)
        {
            this.ExpenseName = ExpenseName;
            this.PromisedDue = PromisedDue;
            this.ActualDue = ActualDue;
            this.Amount = Amount;
        }
        
    }
}
