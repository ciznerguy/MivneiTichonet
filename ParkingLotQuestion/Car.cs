using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotQuestion
{
    //הגדירו את המחלקות ParkingLot ו Car, עבור חניון ומכונית בהתאמה.
    //כתבו את כותרות המחלקות ואת תכונותיהן.bhhh
    public class Car
    {
        private string licensePlate;
        private int time;

        public Car(string licensePlate, int time)
        {
            this.licensePlate = licensePlate;
            this.time = time;
        }
        public int GetTime()
        {
            return time; 
        }
        public string GetLicensePlate()
        { 
          return licensePlate;
        }
    }
}
