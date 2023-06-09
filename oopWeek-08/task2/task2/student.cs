using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   public class student:person
    {
        private  string program;
        private int year;
        private double fee;
       
        public student(string name, string adress, string program, int year, double fee):base(name,adress)
        {
            this.fee = fee;
            this.year = year;
            this.program = program;
        }
        public string getprogram()
        {
            return program;
        }
        public int getyear()
        {
            return year;
        }
        public double getfee()
        {
            return fee;
        }

        public void setprogram(string program)
        {
            this.program = program;
        }
        public void setyear(int year)
        {
            this.year = year;
        }
        public void setfee(int fee)
        {
            this.fee = fee;
        }
        public override string toString()
        {
            return "name" + name + "adress" + adress+"year"+year+"fee"+fee+"program"+program;
        }

    }
}
