using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_task2_classdiagram
{
    class MountainBike:Bicycle
    {
        public int seatHeight;
        public MountainBike(int seatHeight,int cadance,int speed,int gear):base(cadance,  speed,  gear)
        {
         
            this.seatHeight = seatHeight;

        }
        public void getSeatHeight(int seatheight)
        {
          
        }
    }
}
