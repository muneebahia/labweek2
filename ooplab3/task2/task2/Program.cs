using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Time empty_time = new Time(12,12,12);
            Console.WriteLine("Elapsed time in hours:");
            empty_time.printElapsedTimeInHours();
           
           
            Console.WriteLine("Elapsed time in SEC:");
            empty_time.printElapsedTimeInSec();
            Console.WriteLine("Remaining time in hours:");
            empty_time.PrintRemainingTimeInHours();
            Console.WriteLine("Remaining time in sec");
            empty_time.PrintRemainingTimeInSec();

            Time compare = new Time(1,1,1);
            empty_time.CompareTime(compare);

            Console.ReadKey();

        }

    }
}
