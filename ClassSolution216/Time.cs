using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSolution216
{
    public class Time
    {
        private int hour;
        private int minute;

        public Time()
        { 
        
        }
        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;

            if (hour < 0 || hour > 23)
            {
                this.hour = 0;
            }
            if (minute < 0 || minute > 59)
            {
                this.minute = 0;
            }

        }

    }
}
