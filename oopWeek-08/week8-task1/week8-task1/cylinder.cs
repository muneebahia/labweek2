using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_task1
{
    class cylinder:circle
    {
        public double height=1.0;
        public cylinder()
        {

        }
        public cylinder(double radius):base(radius)
        {
            
        }
        public cylinder(double radius, double height)
        {
           
            this.height = height;
        }

        public double getvolume()
        {
            return 1;
        }
        public void setheight(double height)
        {
            this.height = height;
        }

    }
}
