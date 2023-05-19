using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab_2
{
    class Program
    {
        class students
        {
            public string name;
            public int rollNo;
            public float cgpa;

        }

        static void Main(string[] args)
        {/*// first object
            students s1 = new students();
            s1.name = "Muneeba";
            s1.rollNo = 187;
            s1.cgpa = 3.6F;
            Console.WriteLine("Name: {0} rollNo: {1} CGPA: {2}" ,s1.name,s1.rollNo,s1.cgpa);
            Console.Read();
            // second object
            students s2 = new students();
            s2.name = "Tayyba";
            s2.rollNo = 198;
            s2.cgpa = 3.5F;
            Console.WriteLine("Name: {0} rollNo: {1} CGPA: {2}", s2.name, s2.rollNo, s2.cgpa);
            Console.Read();*/

            students studentNO1 = new students();
            Console.WriteLine("ENTER THE NAME OF STUDENT : ");
            studentNO1.name = Console.ReadLine();
            Console.WriteLine("Enter the ROLLno of the student : ");
            studentNO1.rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the CGPA of Student : ");
            studentNO1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0} rollNo: {1} CGPA: {2}", studentNO1.name, studentNO1.rollNo, studentNO1.cgpa);
            Console.ReadKey();

        }
    }
}
