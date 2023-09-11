using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3Solution214
{
    public class Flight
    {
        private string name;
        private string destination;
        private string flightCode;
        private Time flightTime;

        public Flight(string name, string destination, string flightCode, Time flightTime)
        {
            this.name = name;
            this.destination = destination;
            this.flightCode = flightCode;
            this.flightTime = flightTime;
        }

        public string Getname()
        {
            return this.name;
        }
    }
}
