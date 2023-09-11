using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3Solution214
{
    public class Airport
    {
        private Flight[] flights;

        public bool isFly()
        {
            for(int i = 0; i < flights.Length; i++)
            {
                if (this.flights[i].Getname() == "Sky")
                {
                return true;
                }
            }
            return false;
        }
    }
}
