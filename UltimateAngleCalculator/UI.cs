using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateAngleCalculator
{
    static class UI
    {
        public static int HoursMin { get; } = 1;
        public static int HoursMax { get; } = 12;
        public static int MinutesMin { get; } = 0;
        public static int MinutesMax { get; } = 59;
        public static string Greeting { get; } = "Welcome to the unique and most amazing angle calculator.";
        public static string Help { get; } = "\nEnter \"exit\" to leave the program. Else...\n";
        public static string AskForHours { get; } = $"Please specify hours (number between {HoursMin} and {HoursMax})";
        public static string AskForMinutes { get; } = $"Please specify minutes (number between {MinutesMin} and {MinutesMax})";
    }
}
