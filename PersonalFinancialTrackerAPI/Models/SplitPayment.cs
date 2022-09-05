using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PersonalFinancialTrackerAPI
{
    [Serializable]
    public class SplitPayment
    {
        [JsonProperty("ExpenseUID")]
        public byte ExpenseUID { get; set; }

        [JsonProperty("SplitPaymentAmount")]
        public decimal SplitPaymentAmount { get; set; }

    }
}
