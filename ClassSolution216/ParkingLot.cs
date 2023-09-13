using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSolution216
{
    public class ParkingLot
    {
        private Car[] lot = new Car[318];
        
        public ParkingLot() 
        {
            for (int i = 0; i < lot.Length; i++)
            {
                this.lot[i] = null;
            }
        }
        public bool CarIn()
        {
            for (int i = 0; i < lot.Length; i++)
            {
                if (this.lot[i] == null)
                {
                    return true;
                }
            }
            return false;
        }
        public void CarParked(string id, int time, int location)
        {
            Car currCar = new Car(id, time);
            if (this.lot[location] == null)
                this.lot[location] = currCar;
        }
    }
}
