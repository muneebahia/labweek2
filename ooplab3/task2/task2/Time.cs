using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Time
    {
        public int hours;
        public int min;
        public int sec;
       
        public Time(int hours, int min, int sec)
        {
            this.hours = hours;
            this.min = min;
            this.sec = sec;
        }
        public void printElapsedTimeInSec()
        {
            Console.WriteLine(hours*3600 +min*60 + sec);
        }
        public void printElapsedTimeInHours()
        {
            Console.WriteLine(hours+":"+ min + ":" + sec);
        }
        public void PrintRemainingTimeInHours()
        {
            hours = 24 - hours;
            min = 60 - min;
            sec = 60 - sec;

            Console.WriteLine(hours + ":" + min + ":" + sec);
        }
        public void PrintRemainingTimeInSec()
        {
          
            int second = hours * 3600 +  min * 60 + sec;
            Console.WriteLine(86400-second);
        }


        public void CompareTime(Time compare)
        {
            if(hours>compare.hours)
            {
                compare.hours = hours - compare.hours;
            }
            else
            {
                compare.hours =compare.hours-hours;
            }
            if (hours > compare.min)
            {
                compare.min = hours - compare.min;
            }
            else
            {
                compare.min = compare.min - min;
            }
            if (hours > compare.hours)
            {
                compare.sec = sec - compare.sec;
            }
            else
            {
                compare.sec = compare.sec - sec;
            }
            Console.WriteLine("The Time Difference Between Two Clock");
            Console.WriteLine(compare.hours+":"+compare.min+":"+compare.sec);
        }
      

    }
}
