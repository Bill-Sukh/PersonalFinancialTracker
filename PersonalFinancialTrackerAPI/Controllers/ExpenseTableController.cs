using Microsoft.AspNetCore.Mvc;
using PersonalFinancialTrackerAPI.Models;
using Newtonsoft.Json;
using PersonalFinancialTrackerAPI.Rules;

namespace PersonalFinancialTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseTableController : ControllerBase
    {
         
        private readonly ILogger<ExpenseTableController> _logger;
        private readonly string path = @"C:\Users\eclai\Desktop\Bilguut\Bill\Programming\webDevelopment\back-end\C#\PersonalFinancialTracker\PersonalFinancialTrackerAPI\Shared\Database.json";

        public ExpenseTableController(ILogger<ExpenseTableController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(GetJson(path));
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return null;
            }
        }

        [HttpGet("Expense")]
        public IActionResult GetExpense(int ExpenseUID)
        {
            ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(GetJson(path));
            if (data != null)
            {
                var result = data.Expenses.Where(expense => expense.ExpenseUID == ExpenseUID);
                return Ok(result);
            }
            else
            {
                return null;
            }
        }

        [HttpGet("MemberExpenses")]
        public IActionResult GetMemberExpenses(int MemberId)
        {
            ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(GetJson(path));
            var memberExpenses = new List<Expense>();
            var result = new MemberExpenses(); 

            if (data != null)
            {
                //var selectedMember = data.FamilyMembers.Where(member => member.MemberId == MemberId);
                var member =  (from b in data.FamilyMembers
                                           where b.MemberId.Equals(MemberId)
                                           select b).FirstOrDefault();

                foreach (int item in member.ExpenseUIDs)
                {
                    Expense memberExpense = GetExpenseByUID(item);
                    if (memberExpense != null)
                    {
                        memberExpenses.Add(memberExpense);
                    }
                }

                result.PaydayDiv = PaydayRules.DividePayday(member.LastPayday, member.PaydayInterval);
                result.Expenses = memberExpenses;
                return Ok(result);
            }
            else
            {
                return null;
            }
        }

        private string GetJson(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }

        private Expense GetExpenseByUID(int ExpenseUID)
        {
            ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(GetJson(path));
            if (data != null)
            {
                var expense = (from e in data.Expenses
                              where e.ExpenseUID == ExpenseUID
                              select e).FirstOrDefault();
                return expense;
            }
            else
            {
                return null;
            }
        }

    }
}