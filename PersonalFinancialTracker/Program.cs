namespace PersonalFinancialTracker
{
    class Program
    {
        static void Main()
        {
            ExpenseTable table = new ExpenseTable();
            //table.ParseEntryData("FamilyMembers.json");
            var member = table.GetFamilyMemberData("Bilguut");
            var total = table.GetTotalAmountOfExpenses(member);
            Console.WriteLine("Got information of member: " + member.Name + Environment.NewLine + member.LastPayday);
            Console.WriteLine($"Total expenses amount: {total.Item1 + Environment.NewLine}There are {total.Item2} expense for this guy");
        }
    }
}

