using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateAngleCalculator
{
    public static class UserInputValidator
    {
        public static string InputFailedMessage { get; } = $"\n > The number you entered does not meet the conditions.";

        public static bool CheckHoursInput(string hours)
        {
            if (!CheckIfNumber(hours))
                return false;

            var number = Int32.Parse(hours);

            if (number < 1 || number > 12)
                return false;

            return true;
        }

        public static bool CheckMinutesInput(string minutes)
        {
            if (!CheckIfNumber(minutes))
                return false;

            var number = Int32.Parse(minutes);

            if (number < 0 || number > 59)
            {
                return false;
            }

            return true;
        }

        private static bool CheckIfNumber(string userInput)
        {
            if (userInput == null || userInput == "")
                return false;

            foreach (char c in userInput)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
