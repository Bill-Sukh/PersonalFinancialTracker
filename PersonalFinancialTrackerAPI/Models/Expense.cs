using System;
using Newtonsoft.Json;

namespace PersonalFinancialTrackerAPI
{
    [Serializable]
    public class Expense
    {
        [JsonProperty("ExpenseUID")]
        public byte ExpenseUID { get; set; }

        [JsonProperty("PaymentReceiver")]
        public string PaymentReceiver { get; set; }

        [JsonProperty("ExpenseCategory")]
        public string ExpenseCategory { get; set; }

        [JsonProperty("ExpenseName")]
        public string ExpenseName { get; set; }

        [JsonProperty("PromisedDue")]
        public byte PromisedDue { get; set; }

        [JsonProperty("ActualDue")]
        public byte ActualDue { get; set; }

        [JsonProperty("Amount")]
        public decimal Amount { get; set; }

    }
}
