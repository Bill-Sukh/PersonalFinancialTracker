using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTracker
{
    internal class FamilyMember
    {
        private string Name { get; }
        private Expense[] Expenses { get; }
        private byte PaydayInterval { get; }
        private byte LastPayday { get; }

        public FamilyMember(string Name, Expense[] Expenses, byte PaydayInterval, byte LastPayday)
        {
            this.Name = Name;
            this.Expenses = Expenses;
            this.PaydayInterval = PaydayInterval;
            this.LastPayday = LastPayday;
        }
    }
}
