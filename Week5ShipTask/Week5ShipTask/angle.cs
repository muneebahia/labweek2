using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ShipTask
{
    class angle
    {
        public int Degree;
        public float Min;
        public char Direction;

        public angle(int Degree, float Min, char Direction)
        {
            this.Degree = Degree;
            this.Direction = Direction;
            this.Min = Min;
        }
        public angle()
        {

        }
    }
}
