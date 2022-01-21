using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateAngleCalculator
{
    public static class UserInputHandler
    {
        public static double GetHours()
        {
            double hours;

            while (true)
            {
                Console.WriteLine(UI.AskForHours);
                var userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    Environment.Exit(0);
                }

                if (!UserInputValidator.CheckHoursInput(userInput))
                {
                    Console.WriteLine(UserInputValidator.InputFailedMessage);
                    continue;
                }

                hours = Double.Parse(userInput);
                break;
            }

            return hours;
        }

        public static double GetMinutes()
        {
            double minutes;

            while (true)
            {
                Console.WriteLine(UI.AskForMinutes);
                var userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    Environment.Exit(0);
                }

                if (!UserInputValidator.CheckMinutesInput(userInput))
                {
                    Console.WriteLine(UserInputValidator.InputFailedMessage);
                    continue;
                }

                minutes = Double.Parse(userInput);
                break;
            }

            return minutes;
        }
    }
}
