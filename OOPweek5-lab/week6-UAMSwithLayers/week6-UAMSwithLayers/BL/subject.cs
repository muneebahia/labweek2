using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_UAMSwithLayers.BL
{
    class Subject
    {
        public string code;
        public int creditHours;
        public string subjectType;
        public int subjectFee;
        public Subject(string code, string subjectType, int creditHours, int subjectFee)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }
    }
}
