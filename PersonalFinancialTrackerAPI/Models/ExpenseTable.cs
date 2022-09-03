using System;
using Newtonsoft.Json;

namespace PersonalFinancialTrackerAPI.Models
{
    [Serializable]
    public class ExpenseTable
    {
        [JsonProperty("FamilyMembers")]
        public List<FamilyMember> FamilyMembers { get; set; }

        [JsonProperty("Expenses")]
        public List<Expense> Expenses { get; set; }
    }
}
