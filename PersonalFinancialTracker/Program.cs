namespace PersonalFinancialTracker
{
    class Program
    {
        static void Main()
        {
            ExpenseTable table = new ExpenseTable();
            table.ParseEntryData("FamilyMembers.json");
        }
    }
}

