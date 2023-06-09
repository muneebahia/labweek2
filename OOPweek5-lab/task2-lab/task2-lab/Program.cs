using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
using task_02;
namespace task2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3]
            {
                { '@',' ',' '},
                { '@','@',' ' },
                { '@','@','@' },
                { '@','@',' ' },
                { '@',' ',' '},
            };
            char[,] opTriangle = new char[5, 3]
               {
                 { ' ',' ','@' },
                 { ' ','@','@' },
                 { '@','@','@' },
                 { ' ','@','@' },
                 { ' ',' ','@' },

              };
            Boundary boundary = new Boundary(new point(0, 0), new point(0, 90), new point(90, 0), new point(90, 90));
            GameObj g1 = new GameObj(triangle, new point(5,5), "LeftToRight", boundary);
            GameObj g2 = new GameObj(opTriangle, new point(80, 40), "RightToLeft", boundary);
            List<GameObj> list = new List<GameObj>();
            list.Add(g1);
            list.Add(g2);
            while (true)
            {
                Thread.Sleep(50);
                foreach (GameObj g in list)
                {
                                     g.erase();
                                      g.move();
                                        g.draw();
                    
                }
            }
        }
    }
}

