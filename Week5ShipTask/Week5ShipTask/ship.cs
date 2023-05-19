using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ShipTask
{
    class ship
    {
        public string serialNo;
        public angle longitude = new angle();
        public angle latitude = new angle();


        public ship(string serialNo, angle latitude, angle longitude)
        {
            this.serialNo = serialNo;
            this.longitude = longitude;
            this.latitude = latitude;
        }
        public ship()
        {

        }
        public angle returnLocationLatitude(List<ship>ships,string num)
        {
            foreach(ship x in ships)
            {
                if(x.serialNo==num)
                {
                    return x.latitude;
                }
             
            }
            return null;
        }
        public angle returnLocationLongitude(List<ship> ships, string num)
        {
            foreach (ship x in ships)
            {
                if (x.serialNo == num)
                {
                    return x.longitude;
                }
                
            }
            return null;
        }
        public string returnSerialNo(angle longitude,angle latitude,List<ship>ships)
        {
            string serial = "invalid";
            foreach(ship x in ships )
            {
                if(x.latitude.Degree==latitude.Degree && x.latitude.Min==latitude.Min && x.latitude.Direction==latitude.Direction && x.longitude.Degree == longitude.Degree && x.longitude.Min == longitude.Min && x.longitude.Direction == longitude.Direction)
                {
                     serial = x.serialNo;
                    return serial;
                }
                
            }
            return null;

        }
    }
}
