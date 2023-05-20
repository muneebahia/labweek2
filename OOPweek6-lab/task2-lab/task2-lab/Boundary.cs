using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    class Boundary
    {
        public point TopLeft;
        public point TopRight;
        public point BottomLeft;
        public point BottomRight;
        public Boundary()
        {
            this.TopLeft.x = 0;
            this.TopLeft.y = 0;

            this.TopRight.x = 0;
            this.TopRight.y = 90;

            this.BottomLeft.x = 90;
            this.BottomLeft.y = 0;

            this.BottomRight.x = 90;
            this.BottomRight.y = 90;

        }
        public Boundary(point TopLeft, point TopRight, point BottomLeft, point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }
    }
}
