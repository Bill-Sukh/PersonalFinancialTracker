using Microsoft.AspNetCore.Mvc;
using PersonalFinancialTrackerAPI.Models;
using Newtonsoft.Json;

namespace PersonalFinancialTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseTableController : ControllerBase
    {
         
        private readonly ILogger<ExpenseTableController> _logger;

        public ExpenseTableController(ILogger<ExpenseTableController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string fileName = "Database.json";
            using(StreamReader r = new StreamReader(@"C:\Users\eclai\Desktop\Bilguut\Bill\Programming\webDevelopment\back-end\C#\PersonalFinancialTracker\PersonalFinancialTracker\shared\Database.json"))
            {
                string json = r.ReadToEnd();
                ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(json);
                return Ok(data);
            }

            return null;
        }

        [HttpGet("Expense")]
        public IActionResult GetExpense(int ExpenseUID)
        {
            string fileName = "Database.json";
            using (StreamReader r = new StreamReader(@"C:\Users\eclai\Desktop\Bilguut\Bill\Programming\webDevelopment\back-end\C#\PersonalFinancialTracker\PersonalFinancialTracker\shared\Database.json"))
            {
                string json = r.ReadToEnd();
                ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(json);  
                var result = data.Expenses.Where(expense => expense.ExpenseUID == ExpenseUID);
                return Ok(result);
            }
            return null;
        }

        [HttpGet("Member")]
        public IActionResult GetMember(int MemberId)
        {
            string fileName = "Database.json";
            using (StreamReader r = new StreamReader(@"C:\Users\eclai\Desktop\Bilguut\Bill\Programming\webDevelopment\back-end\C#\PersonalFinancialTracker\PersonalFinancialTracker\shared\Database.json"))
            {
                string json = r.ReadToEnd();
                ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(json);
                var result = data.FamilyMembers.Where(member => member.MemberId == MemberId);
                return Ok(result);
            }

            return null;
        }

    }
}