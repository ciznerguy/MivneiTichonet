using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSolution216
{
    public class Airport
    {
        private Flight[] flights;

        public bool IsFly()
        {
            for (int i = 0; i < this.flights.Length; i++)
            {
                if (this.flights[i].GetName() == "Sky")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
