namespace PersonalFinancialTrackerAPI.Rules
{
    public class PaydayRules
    {
        public static bool IsPaydayPassed(DateTime payday)
        {
            if(payday > DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public static int DividePayday(DateTime payday, int paydayInterval)
        {
            if (paydayInterval == 14)
            {
                if (payday.Day > 15)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }

            return 0;
            //else if(paydayInterval == 4)
            //{
                
            //}

        }

    }
}
