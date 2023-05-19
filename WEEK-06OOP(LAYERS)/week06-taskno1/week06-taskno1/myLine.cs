using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week06_taskno1
{
    class myLine
    {
        public mypoint begin;
        public mypoint end;
        public myLine() { }
        public myLine(mypoint begin, mypoint end)  // incomming value
        {
            this.begin = begin;
            this.end = end;
        }
/*        public mypoint getBegin()
        {
            return begin;
        }
        public mypoint getEnd()
        {

            return end;
        }
*/        public void setBegin(mypoint begin)
        {
            this.begin = begin;
        }
        public void setEnd(mypoint end)
        {
            this.end = end;
        }
        public double getLength()
        {
            double length = 0;
            length = Math.Sqrt(Math.Pow((end.x - begin.x), 2) + Math.Pow((end.y - begin.y), 2));
            return length;

        }
        public double getGradient()
        {
            double gradient = 0;
            gradient = (end.y - begin.y) / (end.x - begin.x);

            return gradient;
        }
        public double distanceWithCord()
        {
            double ditance = 0;
            ditance = Math.Sqrt(Math.Pow((begin.x - 0), 2) + Math.Pow((begin.y - 0), 2));
            return ditance;

        }
        public double distanceFromZero()
        {
            double ditance = 0;
            ditance = Math.Sqrt(Math.Pow((end.x - 0), 2) + Math.Pow((end.y - 0), 2));
            return ditance;

        }


    }
}
