using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopweek5lab
{
    class merit
    {
        public string name;
        public int rollNo;
        public float cgpa;
        public float fscmarks;
        public float ecatmarks;
        public float matricmarks;
        public string hometown;
        public bool isHostelite;
       


        public merit(string name, int rollNo, float cgpa, float fscmarks, float ecatmarks, float matricmarks, string hometown,bool isHostelite)
        {
            this.name = name;
            this.rollNo=rollNo;
            this.cgpa=cgpa;
            this.fscmarks=fscmarks;
            this.ecatmarks=ecatmarks;
            this.matricmarks=matricmarks;
            this.hometown=hometown;
            this.isHostelite=isHostelite;

           // this.isAvailingscholorship=isAvailingscholorship;*/
    }
        public merit()
        {

        }
        public void showstudent()
        {
            Console.WriteLine("name :"+name);
            Console.WriteLine("rollNo :" + rollNo);
            Console.WriteLine("cgpa :" + cgpa);
            Console.WriteLine("fscmarks :" + fscmarks);
            Console.WriteLine("matricmarks :" + matricmarks);
            Console.WriteLine("ecatmarks :" + ecatmarks);
            Console.WriteLine("isHostelite :" + isHostelite);
            Console.WriteLine("hometown :" +hometown);
        }
       
        public double Calculatemerit()
        {
           double merit= ((fscmarks / 1100.0F) * 0.6 + (ecatmarks / 400.0F)*0.4) * 100.0F;
            return merit;
        }
        public bool isEligibleforScholorship()
        {
            double per_merit=Calculatemerit();
            if(per_merit>80)
            {
                return true;
            }
            return false;
        }
    }
}
