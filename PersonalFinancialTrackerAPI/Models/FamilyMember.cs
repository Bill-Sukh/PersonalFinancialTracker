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
    public class FamilyMember
    {
        [JsonProperty("MemberId")]
        public int MemberId { get; set; }

        [JsonProperty("Name")]
        public string? Name { get; set; }

        [JsonProperty("ExpenseUIDs")]
        public int[]? ExpenseUIDs { get; set; }

        [JsonProperty("PaydayInterval")]
        public byte PaydayInterval { get; set; }

        [JsonProperty("LastPayday")]
        public byte LastPayday { get; set; }

        [JsonProperty("SplitPayments")]
        public SplitPayment[] SplitPayments { get; set; }

    }
}
