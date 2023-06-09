using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   public class staff:person
    {
      private  string school;
        private double pay;
        
        public staff(string name, string adress, string school,  double pay) : base(name, adress)
        {
            this.pay = pay;
            this.school = school;
           
        }
        public string getschool()
        {
            return school;
        }
        public double getpay()
        {
            return pay;
        }

        public void setschool(string school)
        {
            this.school = school;
        }
        public void setpay(double pay)
        {
            this.pay = pay;
        }
        public override string toString()
        {
            return "Name:" + name+" " + "Adress:" + adress+" "+"Pay:"+pay+" "+"School:"+school;
        }
    }
}
