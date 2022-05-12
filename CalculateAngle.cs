using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechAssignment
{
    public class CalculateAngle
    {
        public int Calculate(double hours, double minutes)
        {
            if(hours == 12)
                hours = 0;
            if(minutes == 60)
            {
                minutes = 0;
                if (hours > 12)
                    hours -= 12;
            }

            //Calculate the angles
            int hoursAngle = (int)((hours * 60 + minutes) * 0.5);
            int minutesAngle = (int)(minutes * 6);

            //Find the difference between two angles
            int angle = Math.Abs(hoursAngle - minutesAngle);

            //Find the smaller angle
            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
