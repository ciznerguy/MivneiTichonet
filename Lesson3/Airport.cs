using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3AtHome
{
    public class Airport
    {
        private  Flight[] flights;

       
        // פעולה בונה המקבלת הפניה למערך של טיסות
        public Airport(Flight[] flights)
        {
            this.flights = flights;
        }
    }
}
