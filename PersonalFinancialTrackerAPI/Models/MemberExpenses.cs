using Newtonsoft.Json;

namespace PersonalFinancialTrackerAPI.Models
{
    public class MemberExpenses
    {
        [JsonProperty("PaydayDiv")]
        public int PaydayDiv { get; set; }

        [JsonProperty("Expenses")]
        public List<Expense> Expenses { get; set; }
    }
}
