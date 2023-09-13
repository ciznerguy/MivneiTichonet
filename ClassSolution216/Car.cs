using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSolution216
{
    public class Car
    {
        private string id;
        private int time;

        public Car(string id, int time)
        {
            this.id = id;
            this.time = time;
        }
        public int GetTime()
        {
            return this.time;        
        }
    }
}
