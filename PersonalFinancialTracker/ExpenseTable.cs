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
        private readonly string fileName = "EntryData.json";
        Entry entryData;

        public ExpenseTable()
        {
            entryData = DeserializeJson(fileName);
        }

        public FamilyMember GetFamilyMemberData(string name)
        {
            foreach(FamilyMember member in entryData.FamilyMembers)
            {
                if(member.Name == name)
                {
                    return member;
                }
            }

            return null;
        }

        public (decimal, byte) GetTotalAmountOfExpenses(FamilyMember member)
        {
            decimal totalAmount = 0;
            byte totalNumberOfExpenses = 0;
            
            foreach(byte expenseUID in member.ExpenseUIDs)
            {
                foreach(Expense expense in entryData.Expenses)
                {
                    if(expenseUID == expense.ExpenseUID)
                    { 
                        if(Contains(expenseUID, member.SplitPayments).Item1)
                        {
                            totalAmount += Contains(expenseUID, member.SplitPayments).Item2;
                            break;
                        }
                        else
                        {
                            totalAmount += expense.Amount;
                            break;
                        }
                    }
                }
            }

            return (totalAmount, totalNumberOfExpenses);
        }

        public (bool, decimal) Contains(byte ExpenseUID, SplitPayment[] arr)
        {
            foreach(SplitPayment sp in arr)
            {
                if(sp.ExpenseUID == ExpenseUID)
                {
                    return (true, sp.SplitPaymentAmount);
                }
            }
            return (false, 0);
        }

        public Entry DeserializeJson(string fileName)
        {
            var data = File.ReadAllText($"../../../shared/{fileName}");
            entryData = Deserialize<Entry>(data);
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
