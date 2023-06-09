using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace week8_task1
{
    class circle
    {
        protected double radius = 1.0;
        private string color = "red";
        public circle()
        {

        }
        public circle(double radius)
        {
            this.radius = radius;
        }
        public circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getradius()
        {
            return radius;
        }
        public void setcolor(double radius)
        {
            this.radius = radius;
        }
        public string getcolor()
        {
            return color;
        }
        public void setcolor(string color)
        {
            this.color = color;
        }
        public void getarea()
        { 
            //code
        }



    }
}
