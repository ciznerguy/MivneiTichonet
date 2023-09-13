using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotQuestion
{
    internal class ParkingLot
    {
        private Car[] parkingSpasces = new Car[318];

        public ParkingLot(Car[] parkingSpasces)
        {
            this.parkingSpasces = parkingSpasces;
            for (int i = 0; i < parkingSpasces.Length; i++) 
            {
                this.parkingSpasces[i] = null; // מסמן שהתא במערך לא מצביע לשום עצם
            }
        }


        public void CarParked(string licensePlate, int hour, int location)
        {

            Car carToAdd = new Car(licensePlate, hour);
           this.parkingSpasces[location] = carToAdd;
        }
        public bool CarIn()
        {
            for (int i = 0;i < parkingSpasces.Length;i++) 
            {
               if (parkingSpasces==null) // נמצא מקום פנוי
                {
                    return true;
                }
            }
            return false;
        }

        public int CarOut (string licensePlate, int timeIn)
        {
            int onlyHourOut =timeIn / 100;
          
            if (timeIn<6 || timeIn >23) // בדיקה האם השעה תקינה - לא חובה
            {
                return -1;
            }
            int i= 0;
            while (i<parkingSpasces.Length && parkingSpasces[i].GetLicensePlate ()!=licensePlate)
            { 
              i++; // מציאת הרכב או הגעה לסוף המערך
            }
            if (i<parkingSpasces.Length )
            {
                int  onlyHourIn=parkingSpasces[i].GetTime()/100;
                return (onlyHourOut-onlyHourIn)*14;

            }
            return 0;// לא יגיע לשורה זו
        }
 
    }

}