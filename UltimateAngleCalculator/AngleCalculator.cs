using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateAngleCalculator
{
    public static class AngleCalculator
    {
        public static double LesserAngleBetweenArrows(double hours, double minutes)
        {
            var hoursAngle = HoursArrowAngle(hours, minutes);
            var minutesAngle = MinutesArrowAngle(minutes);

            switch (minutesAngle - hoursAngle)
            {
                case > 180:
                    return 360 - minutesAngle + hoursAngle;
                case < 0:
                    return hoursAngle - minutesAngle;
                default:
                    return minutesAngle - hoursAngle;
            }
        }

        private static double HoursArrowAngle(double hours, double minutes)
        {
            if (hours == 12)
                hours = 0;

            return Math.Round((hours * 30) + (30 * minutes / 60), 2, MidpointRounding.AwayFromZero);

        }

        private static double MinutesArrowAngle(double minutes)
        {
            return minutes * 6;
        }
    }
}
