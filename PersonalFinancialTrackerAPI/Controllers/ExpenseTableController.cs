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
        private readonly string path = @"C:\Users\eclai\Desktop\Bilguut\Bill\Programming\webDevelopment\back-end\C#\PersonalFinancialTracker\PersonalFinancialTracker\shared\Database.json";

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

        [HttpGet("Member")]
        public IActionResult GetMember(int MemberId)
        {
            ExpenseTable data = JsonConvert.DeserializeObject<ExpenseTable>(GetJson(path));
            if (data != null)
            {
                var result = data.FamilyMembers.Where(member => member.MemberId == MemberId);
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
    }
}