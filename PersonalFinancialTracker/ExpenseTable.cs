using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTracker
{
    internal class ExpenseTable
    {
        private readonly string TableHeaderLeft = "";
        private readonly string fileName = "FamilyMembers.json";
        Entry entryData;

        public ExpenseTable()
        {
            entryData = ParseEntryData(fileName);
        }

        //public FamilyMember GetFamilyMemberData(string name)
        //{   

        //    return 
        //}

        public int TotalAmount()
        {
            return 0;
        }

        public Entry ParseEntryData(string fileName)
        {
            var data = File.ReadAllText($"../../../shared/{fileName}");
            entryData = Deserialize<Entry>(data);
            Console.WriteLine(data);
            return entryData;
        }

        public T Deserialize<T>(string json) {
            var obj = Activator.CreateInstance<T>();
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                var serializer = new DataContractJsonSerializer(obj.GetType());
                obj = (T)serializer.ReadObject(ms);
                return obj;
            }
        }
    }
}
