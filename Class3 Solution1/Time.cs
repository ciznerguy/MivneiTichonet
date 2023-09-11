using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3Solution214
{
    public class Time
    {
        private int hour;
        private int minutes;

        public Time()
        {

        }
        public Time(int hour, int minutes)
        {
            this.hour = hour;
            this.minutes = minutes;
            if (this.hour < 0 || this.hour > 23) 
            { 
                this.hour = 0;
            }
            if(this.minutes<0 || this.minutes>59) 
            {
                this.minutes = 0;
            }
        }
    }
}
