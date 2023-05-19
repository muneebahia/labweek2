using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab2
{
    class Program
    {
        class student
        {
            public string name;
            public int RollNo;
            public float CGPA;
            public string ishostelite;
            public string Department;

        }

        static int menu()
        {
            Console.Clear();
            int choice;
            Console.WriteLine("1. Add a student ");
            Console.WriteLine("2. view students record ");
            Console.WriteLine("3. top 3 students ");
            Console.WriteLine("4. Exit ");
            choice = int.Parse(Console.ReadLine());
            return choice;
            
        }

        static void studentsrecord(student[] studentArry,int count)
        {
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("StudentName : {0}\n   Rollno: {1}\n CGPA: {2}\n Hostelite: {3}\nDepartment: {4}", studentArry[i].name, studentArry[i].RollNo, studentArry[i].CGPA, studentArry[i].ishostelite, studentArry[i].Department);

            }
            Console.WriteLine("Press  any key to continue");
            Console.ReadKey();
        }
        static void TOpThreeStudents(student[] studentArry, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (studentArry[i].CGPA < studentArry[j].CGPA)
                    {
/*                        float temp = studentArry[i].CGPA;
                        studentArry[i].CGPA = studentArry[j].CGPA;
                        studentArry[j].CGPA = temp;
*/
                        student temparry = studentArry[i];
                        studentArry[i] = studentArry[j];
                        studentArry[j] = temparry;
                    }

                }

            }
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("NO RESULT FOUND");
            }
            else if (count == 1)
            {
                studentsrecord(studentArry, 1);
            }
            else if (count == 2)
            {
                //studentsrecord(studentArry, 2);
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("StudentName : {0}\n Rollno: {1}\n CGPA: {2}\n Hostelite: {3}\n Department: {4}", studentArry[i].name, studentArry[i].RollNo, studentArry[i].CGPA, studentArry[i].ishostelite, studentArry[i].Department);
                }
            }
            else
            {
                // studentsrecord(studentArry, 3);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("StudentName : {0}\n Rollno: {1}\n CGPA: {2}\n Hostelite: {3}\n Department: {4}", studentArry[i].name, studentArry[i].RollNo, studentArry[i].CGPA, studentArry[i].ishostelite, studentArry[i].Department);
                }

            }
            Console.ReadKey();
        }

        static student AddStudents()
        {
            student studentNO1 = new student();
            Console.WriteLine("ENTER THE NAME OF STUDENT : ");
            studentNO1.name = Console.ReadLine();
            Console.WriteLine("Enter the ROLLno of the student : ");
            studentNO1.RollNo =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the CGPA of Student : ");
            studentNO1.CGPA = float.Parse(Console.ReadLine());
            Console.WriteLine("student is hostelite (choose yes||no) : ");
            studentNO1.ishostelite = Console.ReadLine();
            Console.WriteLine("ENTER THE NAME OF Department : ");
            studentNO1.Department = Console.ReadLine();
            return studentNO1;
            
        }

        static void Main(string[] args)
        {
            student[] studentArry = new student[50];
            int option;
            int count = 0;
            do
            {
                option = menu();
                if (option == 1)
                {
                    studentArry[count] = AddStudents();
                    count++;
                }
                else if (option == 2)
                {
                    studentsrecord(studentArry, count);
                }
                else if (option == 3)
                {
                    TOpThreeStudents(studentArry, count);
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID choice!!!");
                }

            }
            while (option != 4);
            {
                Console.WriteLine("Enter choice:");
            }

        }
    }
}
