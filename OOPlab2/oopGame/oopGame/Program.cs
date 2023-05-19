using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
using System.IO;
namespace oopGame
{
    class Program
    {
        static int score = 0;
        static int inkio_health = 50;
        static int redio_health = 70;
        static int twinklo_health = 80;
        static int player_health = 50;
        // global arrays and variables //
        // player bullets
        static int[] bulletX = new int[1000];
        static int[] bulletY = new int[1000];
        static Boolean[] isBulletActive = new Boolean[1000];
        static int bulletCount = 0;

        static int[] inkiobulletX = new int[1000];
        static int[] inkiobulletY = new int[1000];
        static Boolean[] isinkioBulletActive = new Boolean[1000];
        static int inkiobulletCount = 0;

        static int[] rediobulletX = new int[1000];
        static int[] rediobulletY = new int[1000];
        static Boolean[] isredioBulletActive = new Boolean[1000];
        static int rediobulletCount = 0;

        static int[] twinklobulletX = new int[1000];
        static int[] twinklobulletY = new int[1000];
        static Boolean[] istwinkloBulletActive = new Boolean[1000];
        static int twinklobulletCount = 0;

        static char[,] maze = new char[34, 121];
        //directions
        static string inkioDirection = "Left";
        static string redioDirection = "Left";
        static string twinkloDirection = "Left";
        //timers
        static int timer = 3;
        static int timer1 = 5;
        static int timer2 = 7;
        static int inkiotimer = 0;
        static int rediotimer = 0;
        static int twinklotimer = 0;

        // player coordinates
        static int tankX = 5;
        static int tankY = 20;
        // coordinates of inkio
        static int enemyX = 4;
        static int enemyY = 2;
        // coordinates of redio
        static int enemyA = 50;
        static int enemyB = 2;
        // coordinates of TWINKLO
        static int enemyC = 90;
        static int enemyD = 2;
        // coordinates of Jake
        static int JakeX = 10;
        static int JakeY = 10;
        static char body = (char)254;
        static char arm = (char)45;
        static char box = (char)219;
        static char[,] tank = {
                { '.', ':', '.'},
                   { box, box, box},
                   { '0', ' ', '0'}
            };
        // enemy character
        static char[,] enemy1 = {
                { box, box, box },
                { ' ', ':', ' '},
                { ' ', ':', ' '}

            };
        static char[,] enemy2 = {
                     { box, box, box},
                     { ' ', ':', ' '},
                     { ' ', ':', ' '}
};
        // enemy character
        static char[,] enemy3 = {
                     { box, box, box},
                     { ' ', ':', ' '},
                     { ' ', ':', ' '}
};

        static char[,] Jake = {
                   { ' ', '|', ' '},
                   { arm, body, arm},
                   { ' ', '|', ' '}
};

        static void Main(string[] args)
        {
            Console.Clear();
            //game_name();
            //game_logo();
            wholeGame();

        }

        static void printMaze()
        {
            //SetConsoleTextAttribute(acolor, 14);
            for (int i = 0; i < maze.GetLength(1); i++)
            {
                for (int j = 0; j < 121; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine();
            }
        }
        // CHARACTER MOVEMENT //
        static void moveTankLeft(char[,] maze)
        {
            if (maze[tankY, tankX - 2] == ' ' && maze[tankY + 1, tankX - 2] == ' ' && maze[tankY + 2, tankX - 2] == ' ')
            {
                eraseTank();
                tankX = tankX - 1;
                printTank();
            }
        }

        static void moveTankRight(char[,] maze)
        {
            if (maze[tankY, tankX + 3] == ' ' && maze[tankY + 1, tankX + 3] == ' ' && maze[tankY + 2, tankX + 3] == ' ')
            {
                eraseTank();
                tankX = tankX + 1;
                printTank();
            }
        }
        static void moveTankUp(char[,] maze)
        {
            if (maze[tankY - 1, tankX] == ' ' && maze[tankY - 1, tankX + 1] == ' ' && maze[tankY - 1, tankX + 2] == ' ')
            {
                eraseTank();
                tankY = tankY - 1;
                printTank();
            }
        }
        static void moveTankDown(char[,] maze)
        {
            if (maze[tankY + 4, tankX] == ' ' && maze[tankY + 4, tankX + 1] == ' ' && maze[tankY + 4, tankX + 2] == ' ')
            {
                eraseTank();
                tankY = tankY + 1;
                printTank();
            }
        }
        static void moveinkio(char[,] maze)
        {
            if (inkiotimer == 2)
            {
                //generateinkioBullet();
                inkiotimer = 0;
            }
            inkiotimer++;
            if (inkioDirection == "Right")
            {

                if (maze[enemyY, enemyX + 6] == ' ')
                {
                    eraseinkio();
                    enemyX++;
                    printinkio();
                }
                else if (maze[enemyY, enemyX + 6] == '#' || maze[enemyY, enemyX + 6] == '.')
                {
                    inkioDirection = "Left";
                }
            }
            if (inkioDirection == "Left")
            {

                if (maze[enemyY, enemyX - 1] == ' ')
                {
                    eraseinkio();
                    enemyX--;
                    printinkio();
                }
                if (maze[enemyY, enemyX - 1] == '#' || maze[enemyY, enemyX - 1] == '.')
                {
                    inkioDirection = "Right";
                }
            }
        }
        static void moveredio(char[,] maze)
        {
            if (rediotimer == 2)
            {
                //generateredioBullet();
                rediotimer = 0;
            }
            rediotimer++;
            if (redioDirection == "Right")
            {

                if (maze[enemyB, enemyA + 6] == ' ' || maze[enemyB, enemyA + 6] == '.')
                {
                    eraseredio();
                    enemyA++;
                    printredio();
                }
                else if (maze[enemyB, enemyA + 6] == '#')
                {
                    redioDirection = "Left";
                }
            }
            if (redioDirection == "Left")
            {

                if (maze[enemyB, enemyA - 1] == ' ' || maze[enemyB, enemyA - 1] == '.')
                {
                    eraseredio();
                    enemyA--;
                    printredio();
                }
                if (maze[enemyB, enemyA - 1] == '#')
                {
                    redioDirection = "Right";
                }
            }
        }
        static void movetwinklo(char[,] maze)
        {
            if (twinklotimer == 2)
            {
                //generatetwinkloBullet();
                twinklotimer = 0;
            }
            twinklotimer++;
            if (twinkloDirection == "Right")
            {

                if (maze[enemyD, enemyC + 6] == ' ')
                {
                    erasetwinklo();
                    enemyC++;
                    printtwinklo();
                }
                else if (maze[enemyD, enemyC + 6] == '#' || maze[enemyD, enemyC + 6] == '.')
                {
                    twinkloDirection = "Left";
                }
            }
            if (twinkloDirection == "Left")
            {

                if (maze[enemyD, enemyC - 1] == ' ')
                {
                    erasetwinklo();
                    enemyC--;
                    printtwinklo();
                }
                if (maze[enemyD, enemyC - 1] == '#' || maze[enemyD, enemyC - 1] == '.')
                {
                    twinkloDirection = "Right";
                }
            }
        }
        static void printTank()
        {

            for (int idx = 0; idx < 3; idx++)
            {
                Console.SetCursorPosition(tankX, tankY + idx);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(tank[idx, j]);
                }
                Console.WriteLine(" ");
            }
        }

        static void printinkio()
        {
            // SetConsoleTextAttribute(acolor, 5);
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(enemyX, enemyY + i);
                for (int idx = 0; idx < 3; idx++)
                {
                    Console.WriteLine(enemy1[i, idx]);
                }
                Console.WriteLine(" ");
            }
        }
        static void printredio()
        {
            // SetConsoleTextAttribute(acolor, 4);
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(enemyA, enemyB + i);
                for (int idx = 0; idx < 3; idx++)
                {
                    Console.WriteLine(enemy2[i, idx]);
                }
                Console.WriteLine(" ");
            }
        }
        static void printtwinklo()
        {
            //SetConsoleTextAttribute(acolor, 6);
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(enemyC, enemyD + i);
                for (int idx = 0; idx < 3; idx++)
                {
                    Console.WriteLine(enemy3[i, idx]);
                }
                Console.WriteLine(" ");
            }
        }
        static void eraseinkio()
        {
            for (int idx = 0; idx < 3; idx++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(enemyX + idx, enemyY + i);
                    Console.WriteLine(" ");
                }
            }
        }
        static void eraseredio()
        {
            for (int idx = 0; idx < 3; idx++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(enemyA + idx, enemyB + i);
                    Console.WriteLine(" ");
                }
            }
        }
        static void erasetwinklo()
        {
            for (int idx = 0; idx < 3; idx++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(enemyC + idx, enemyD + i);
                    Console.WriteLine(" ");
                }
            }
        }

        static void eraseTank()
        {
            for (int idx = 0; idx < 3; idx++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(tankX + i, tankY + idx);
                    Console.WriteLine(" ");
                }
            }
        }
        static void generateBullet()
        {
            bulletX[bulletCount] = tankX;
            bulletY[bulletCount] = tankY - 1;
            isBulletActive[bulletCount] = true;
            Console.SetCursorPosition(tankX, tankY - 1);
            Console.WriteLine(".");
            bulletCount++;
        }
        // move bullet
        static void moveBullet()
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {

                    if (maze[bulletX[x], bulletY[x] - 1] != ' ')
                    {
                        eraseBullet(bulletX[x], bulletY[x]);
                        makeBulletInactive(x);
                    }
                    else
                    {
                        eraseBullet(bulletX[x], bulletY[x]);
                        bulletY[x] = bulletY[x] - 1;
                        printBullet(bulletX[x], bulletY[x]);
                    }
                }
            }
        }
        // supporting functions
        static void printBullet(int x, int y)
        {
            //SetConsoleTextAttribute(acolor, 2);
            Console.SetCursorPosition(x, y);
            Console.WriteLine(".");
        }
        static void eraseBullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }
        static void makeBulletInactive(int idx)
        {
            isBulletActive[idx] = false;
        }
        // collisionn detection
        // collision with enemy
        static void bulletCollionWithinkio()
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {

                    if (bulletX[x] == enemyX && (bulletY[x] - 1 == enemyY || bulletY[x] == enemyY + 2 || bulletY[x] == enemyY + 3))
                    {
                        addScore();
                        eraseInkioHealth();
                    }
                    if (enemyX - 1 == bulletX[x] && enemyY + 1 == bulletY[x])
                    {
                        addScore();
                        eraseInkioHealth();
                    }
                }
            }
        }
        static void bulletCollionWithredio()
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {

                    if (bulletX[x] == enemyA && (bulletY[x] - 1 == enemyB || bulletY[x] == enemyB + 2 || bulletY[x] == enemyB + 3))
                    {
                        addScore();
                        eraseRedioHealth();
                    }
                    if (enemyA - 1 == bulletX[x] && enemyB + 1 == bulletY[x])
                    {
                        addScore();
                        eraseRedioHealth();
                    }
                }
            }
        }
        static void bulletCollionWithtwinklo()
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {

                    if (bulletX[x] == enemyC && (bulletY[x] - 1 == enemyD || bulletY[x] == enemyC + 2 || bulletY[x] == enemyD + 3))
                    {
                        addScore();
                        eraseTwinkloHealth();
                    }
                    if (enemyC - 1 == bulletX[x] && enemyD + 1 == bulletY[x])
                    {
                        addScore();
                        eraseTwinkloHealth();
                    }
                }
            }
        }

        static void generateinkioBullet()
        {
            inkiobulletX[inkiobulletCount] = enemyX + 1;
            inkiobulletY[inkiobulletCount] = enemyY + 3;
            isinkioBulletActive[inkiobulletCount] = true;
            Console.SetCursorPosition(enemyX + 1, enemyY + 3);
            Console.WriteLine("-");
            inkiobulletCount++;
        }
        static void generateredioBullet()
        {
            rediobulletX[rediobulletCount] = enemyA + 1;
            rediobulletY[rediobulletCount] = enemyB + 3;
            isredioBulletActive[rediobulletCount] = true;
            Console.SetCursorPosition(enemyA + 1, enemyB + 3);
            Console.WriteLine("-");
            rediobulletCount++;
        }
        static void generatetwinkloBullet()
        {
            twinklobulletX[twinklobulletCount] = enemyC + 1;
            twinklobulletY[twinklobulletCount] = enemyD + 3;
            istwinkloBulletActive[twinklobulletCount] = true;
            Console.SetCursorPosition(enemyC + 1, enemyD + 3);
            Console.WriteLine("-");
            twinklobulletCount++;
        }

        static void moveinkioBullet()
        {
            for (int x = 0; x < inkiobulletCount; x++)
            {
                if (isinkioBulletActive[x] == true)
                {
                    if (maze[inkiobulletX[x], inkiobulletY[x] + 1] != ' ')
                    {
                        eraseinkioBullet(inkiobulletX[x], inkiobulletY[x]);
                        makeinkioBulletInactive(x);
                    }
                    else
                    {
                        eraseinkioBullet(inkiobulletX[x], inkiobulletY[x]);
                        inkiobulletY[x] = inkiobulletY[x] + 1;
                        printinkioBullet(inkiobulletX[x], inkiobulletY[x]);
                    }
                }
            }
        }
        static void moveredioBullet()
        {
            for (int x = 0; x < rediobulletCount; x++)
            {
                if (isredioBulletActive[x] == true)
                {

                    if (maze[rediobulletY[x] + 1, rediobulletX[x]] != ' ')
                    {
                        eraseredioBullet(rediobulletX[x], rediobulletY[x]);
                        makeredioBulletInactive(x);
                    }
                    else
                    {
                        eraseredioBullet(rediobulletX[x], rediobulletY[x]);
                        rediobulletY[x] = rediobulletY[x] + 1;
                        printredioBullet(rediobulletX[x], rediobulletY[x]);
                    }
                }
            }
        }
        static void movetwinkloBullet()
        {
            for (int x = 0; x < twinklobulletCount; x++)
            {
                if (istwinkloBulletActive[x] == true)
                {

                    if (maze[twinklobulletY[x] + 1, twinklobulletX[x]] != ' ')
                    {
                        erasetwinkloBullet(twinklobulletX[x], twinklobulletY[x]);
                        maketwinkloBulletInactive(x);
                    }
                    else
                    {
                        erasetwinkloBullet(twinklobulletX[x], twinklobulletY[x]);
                        twinklobulletY[x] = twinklobulletY[x] + 1;
                        printtwinkloBullet(twinklobulletX[x], twinklobulletY[x]);
                    }
                }
            }
        }

        static void printinkioBullet(int x, int y)
        {
            // SetConsoleTextAttribute(acolor, 5);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("-");
        }
        static void printredioBullet(int x, int y)
        {
            // SetConsoleTextAttribute(acolor, 4);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("-");
        }
        static void printtwinkloBullet(int x, int y)
        {
            // SetConsoleTextAttribute(acolor, 6);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("-");
        }

        static void eraseinkioBullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }
        static void eraseredioBullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }
        static void erasetwinkloBullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }

        static void makeinkioBulletInactive(int idx)
        {
            isinkioBulletActive[idx] = false;
        }
        static void makeredioBulletInactive(int idx)
        {
            isredioBulletActive[idx] = false;
            // isinkioBulletActive[idx] = false;
        }
        static void maketwinkloBulletInactive(int idx)
        {
            istwinkloBulletActive[idx] = false;
        }
        //addscore
        static void addScore()
        {
            score++;
        }
        static void printScore()
        {
            Console.SetCursorPosition(2, 28);
            Console.WriteLine("score :{0} ", score);
        }
        // supporting functions
        static void printInkioHealth()
        {
            //SetConsoleTextAttribute(acolor, 1);
            Console.SetCursorPosition(2, 30);
            Console.WriteLine("Inkio Health:{0}", inkio_health);
        }
        static void printRedioHealth()
        {
            // SetConsoleTextAttribute(acolor, 4);
            Console.SetCursorPosition(2, 31);
            Console.WriteLine("Redio Health:{0}", redio_health);
        }
        static void printTwinkloHealth()
        {
            //SetConsoleTextAttribute(acolor, 6);
            Console.SetCursorPosition(2, 32);
            Console.WriteLine("Twinklo Health{0}:", twinklo_health);
        }
        static void eraseInkioHealth()
        {
            inkio_health = inkio_health - 5;
            if (inkio_health >= 0)
            {
                Console.SetCursorPosition(3, 30);
                Console.WriteLine(inkio_health);
            }
        }
        static void eraseRedioHealth()
        {
            redio_health = redio_health - 5;
            if (redio_health >= 0)
            {
                Console.SetCursorPosition(3, 31);
                Console.WriteLine(redio_health);
            }
        }
        static void eraseTwinkloHealth()
        {
            twinklo_health = twinklo_health - 5;
            if (twinklo_health >= 0)
            {
                Console.SetCursorPosition(3, 32);
                Console.WriteLine(twinklo_health);
            }
        }
        static void printTankHealth()
        {
            //SetConsoleTextAttribute(acolor, 2);
            Console.SetCursorPosition(2, 29);
            Console.WriteLine("Player Health:{0}", player_health);
        }
        static void eraseTankHealth()
        {
            player_health = player_health - 1;
            Console.SetCursorPosition(2, 29);
            Console.WriteLine(player_health);
        }
        static void bulletCollionWithtTank()
        {
            for (int x = 0; x < inkiobulletCount; x++)
            {
                if (isinkioBulletActive[x] == true)
                {

                    if (inkiobulletX[x] == tankX + 3 && (inkiobulletY[x] == tankY + 1 || inkiobulletY[x] == tankX + 2 || inkiobulletY[x] == tankY + 1))
                    {
                        eraseTankHealth();
                    }
                    if (inkiobulletX[x] == tankX + 1 && inkiobulletY[x] == tankY + 1)
                    {
                        eraseTankHealth();
                    }
                }
            }
            for (int x = 0; x < rediobulletCount; x++)
            {
                if (isredioBulletActive[x] == true)
                {

                    if (rediobulletX[x] == tankX + 3 && (rediobulletY[x] == tankY + 1 || rediobulletY[x] == tankX + 2 || rediobulletY[x] == tankY + 1))
                    {
                        eraseTankHealth();
                    }
                    if (rediobulletX[x] == tankX + 13 && rediobulletY[x] == tankY + 1)
                    {
                        eraseTankHealth();
                    }
                }
            }
            for (int x = 0; x < twinklobulletCount; x++)
            {
                if (istwinkloBulletActive[x] == true)
                {

                    if (twinklobulletX[x] == tankX + 3 && (twinklobulletY[x] == tankY + 1 || twinklobulletY[x] == tankX + 2 || twinklobulletY[x] == tankY + 1))
                    {
                        eraseTankHealth();
                    }
                    if (twinklobulletX[x] == tankX + 1 && twinklobulletY[x] == tankY + 1)
                    {
                        eraseTankHealth();
                    }
                }
            }
        }
        static void playerCollisioWwithInkio()
        {
            //////////////////////////////When Tank is Down/////////////////////////////////////////////////
            if (enemyX + 3 == tankX && (enemyY == tankY || enemyY == tankY + 1 || enemyY == tankY - 1 || enemyY == tankY - 2))
            {
                eraseTankHealth();
            }
            //////////////////////////////When Tank is Right/////////////////////////////////////////////////
            if (enemyX + 3 == tankX && (enemyY == tankY || enemyY == tankY + 1 || enemyY == tankY - 1 || enemyY == tankY - 2))
            {
                eraseTankHealth();
            }
            //////////////////////////////When Tank is Left/////////////////////////////////////////////////
            if (enemyX - 3 == tankX && (enemyY == tankY || enemyY == tankY - 1 || enemyY == tankY - 1 || enemyY == tankY - 2))
            {
                eraseTankHealth();
            }
        }
        static void playerCollisioWwithRedio()
        {
            //////////////////////////////When Tank is Down/////////////////////////////////////////////////
            if (enemyA + 3 == tankX && (enemyB == tankY || enemyB == tankY + 1 || enemyB == tankY - 1 || enemyB == tankY - 2))
            {
                eraseTankHealth();
            }
            //////////////////////////////When Tank is Right/////////////////////////////////////////////////
            if (enemyA + 3 == tankX && (enemyB == tankY || enemyB == tankY + 1 || enemyB == tankY - 1 || enemyB == tankY - 2))
            {
                eraseTankHealth();
            }
            //////////////////////////////When Tank is Left/////////////////////////////////////////////////
            if (enemyA - 3 == tankX && (enemyB == tankY || enemyB == tankY - 1 || enemyB == tankY - 1 || enemyB == tankY - 2))
            {
                eraseTankHealth();
            }
        }
        static void playerCollisioWwithTwinklo()
        {
            //////////////////////////////When Tank is Down/////////////////////////////////////////////////
            if (enemyC + 3 == tankX && (enemyD == tankY || enemyD == tankY + 1 || enemyD == tankY - 1 || enemyD == tankY - 2))
            {
                eraseTankHealth();
            }
            //////////////////////////////When Tank is Right/////////////////////////////////////////////////
            if (enemyC + 3 == tankX && (enemyD == tankY || enemyD == tankY + 1 || enemyD == tankY - 1 || enemyD == tankY - 2))
            {
                eraseTankHealth();
            }
            //////////////////////////////When Tank is Left/////////////////////////////////////////////////
            if (enemyC - 3 == tankX && (enemyD == tankY || enemyD == tankY - 1 || enemyD == tankY - 1 || enemyD == tankY - 2))
            {
                eraseTankHealth();
            }
        }
        static void printJake()
        {
            //SetConsoleTextAttribute(acolor, 11);
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(JakeX, JakeY + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(Jake[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
        static void eraseJake()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(JakeX, JakeY + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }
        }
        static void moveJake(int x, int y)
        {


            if (x > JakeX && y > JakeY)
            {

                if (maze[JakeX, JakeY + 2] == ' ' && JakeY < 14)
                {
                    eraseJake();
                    JakeY++;
                    printJake();
                }

                if (maze[JakeX + 3, JakeY] == ' ')
                {
                    eraseJake();
                    JakeX++;
                    printJake();
                }
            }
            else if (x == JakeX && y > JakeY)
            {

                if (maze[JakeX, JakeY + 2] == ' ' && JakeY < 14)
                {
                    eraseJake();
                    JakeY++;
                    printJake();
                }
            }
            else if (x < JakeX && y > JakeY)
            {

                if (maze[JakeX, JakeY + 2] == ' ' && JakeY < 14)
                {
                    eraseJake();
                    JakeY++;
                    printJake();
                }

                if (maze[JakeX - 1, JakeY] == ' ')
                {
                    eraseJake();
                    JakeX--;
                    printJake();
                }
            }
            else if (x > JakeX && y < JakeY)
            {

                if (maze[JakeX, JakeY - 1] == ' ' && JakeY < 14)
                {
                    eraseJake();
                    JakeY++;
                    printJake();
                }
            }
            else
            {

                if (maze[JakeX, JakeY - 1] == ' ' && JakeY < 14)
                {
                    eraseJake();
                    JakeY--;
                    printJake();
                }
            }
        }
        static void game_logo()
        {
            //SetConsoleTextAttribute(acolor, 2);
            Console.WriteLine("                                                                                         ----.  -== ");
            Console.WriteLine("                                                                                      .:=*       .* ");
            Console.WriteLine("                                                                                 :----:  += :----.  ");
            Console.WriteLine("                                           ::::::::::::::::::             .:----:..:::::: .:.       ");
            Console.WriteLine("                                         -=                  =.      .----:  .----:                 ");
            Console.WriteLine("                                        :=                    *:--:::..::::::.                      ");
            Console.WriteLine("                                        *                     .+ .----:                             ");
            Console.WriteLine("                          --:::::::::+  #                      #-.                                  ");
            Console.WriteLine("                          *          +. *                      *                                    ");
            Console.WriteLine("                        .:#          +-:+::::::::::::::::::::::+:::-:                               ");
            Console.WriteLine("                       +: *          +.                              =-                             ");
            Console.WriteLine("                      =   .:::::::::::                                .+.                           ");
            Console.WriteLine("                     *                                                  *.                          ");
            Console.WriteLine("                  .:==:::::::::::::::::::::::::::------::::::::::----:::-+:::                       ");
            Console.WriteLine("                -=:                                                          -=                     ");
            Console.WriteLine("              :=  :--=+=------+++--------=*+---------=+++---:::--=++---=.  +.                       ");
            Console.WriteLine("             =:.=-.=-. .-=  -=.    .=-   ---.  .:-=.  ---.  .:-=   =-. .:-: :+  =:                  ");
            Console.WriteLine("            :  =: :-     -=:=        =- *          +.+:         * +.      =  *                      ");
            Console.WriteLine("                ==.+     +.::        :=.=          .-#          -::+     .=-=                       ");
            Console.WriteLine("                  -==---   +:      :+  +:        . :+        -+   ----+*=                           ");
            Console.WriteLine("                     ::-::-::++==---:    :--::::---    --::::-=:::::-::-:                           ");
            Console.WriteLine("                                .:----------------------------::.                                   ");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static void keys()
        {
            //SetConsoleTextAttribute(acolor, 14);
            Console.WriteLine(" ##    ## ######## ##    ##  ###### ");
            Console.WriteLine(" ##   ##  ##        ##  ##  ##    ##");
            Console.WriteLine(" ##  ##   ##         ####   ##      ");
            Console.WriteLine(" #####    ######      ##     ###### ");
            Console.WriteLine(" ##  ##   ##          ##          ##");
            Console.WriteLine(" ##   ##  ##          ##    ##    ##");
            Console.WriteLine(" ##    ## ########    ##     ###### ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            //SetConsoleTextAttribute(acolor, 14);
            Console.WriteLine("Press up key to move up");
            Console.WriteLine("Press down key to move ");
            Console.WriteLine("Press left key to move left");
            Console.WriteLine("Press right key to move right");
            Console.WriteLine("Press space key to shoot");
        }
        static void instructions()
        {
            //SetConsoleTextAttribute(acolor, 14);
            Console.WriteLine("####   ###  ##   ## ##   #### ##  ### ##   ##  ###   ## ##   #### ##    ####    ## ##   ###  ##   ## ## ");
            Console.WriteLine(" ##      ## ##  ##   ##  # ## ##   ##  ##  ##   ##  ##   ##  # ## ##     ##    ##   ##    ## ##  ##   ##");
            Console.WriteLine(" ##     # ## #  ####       ##      ##  ##  ##   ##  ##         ##        ##    ##   ##   # ## #  ####   ");
            Console.WriteLine(" ##     ## ##    #####     ##      ## ##   ##   ##  ##         ##        ##    ##   ##   ## ##    ##### ");
            Console.WriteLine(" ##     ##  ##      ###    ##      ## ##   ##   ##  ##         ##        ##    ##   ##   ##  ##      ###");
            Console.WriteLine(" ##     ##  ##  ##   ##    ##      ##  ##  ##   ##  ##   ##    ##        ##    ##   ##   ##  ##  ##   ##");
            Console.WriteLine("####   ###  ##   ## ##    ####    #### ##   ## ##    ## ##    ####      ####    ## ##   ###  ##   ## ## ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            //SetConsoleTextAttribute(acolor, 14);
            Console.WriteLine("1.shoot the enemies to get extra point");
            Console.WriteLine("2.Hit the enemies to get the power");
            Console.WriteLine("3.kill all the enemies to win the game");
            Console.WriteLine("4.save your player from the bullets of enemies");
            Console.WriteLine("5.the power of player decrease if the bullet from the enemy side hits the player");
            Console.WriteLine("6.the power of enemy decrease if the bullet from the player side hits the enemy");
            Console.WriteLine("7.the enemy is killed by the player if the power of enemies reduces to zero ");
            Console.WriteLine("8.If the bullet from the player hits the enemy the score and power increase ");
        }


        static void game_name()
        {
            // SetConsoleTextAttribute(acolor, 11);
            Console.WriteLine("######     ###    ##  ##   ### ###           ######   ######    #####    ##  ##  ######    ###     ######  ");
            Console.WriteLine(" ######   #####   ### ###   ## ###            ######  ### ###  ### ###  ### ###   ## ###   ###      ###### ");
            Console.WriteLine("  ###    ### ###  ### ###   #####              ###    ###  ##  ### ###  ### ###   ## ###   ###      ##     ");
            Console.WriteLine("  ###    ### ###  #### ##  #####               ###    ### ###  ##   ##  ##  ###   #####   ###      ######  ");
            Console.WriteLine("  ###    ### ###  ## ####  ####                ###    ######   ##   ##  ###  ##  ### ##   ###      #####   ");
            Console.WriteLine("  ###    #######  ### ###  ######              ###    ### ###  ### ###  ### ###  ### ###  ### ###  ###     ");
            Console.WriteLine("  ###    ### ###  ### ###  ### ###             ###     ### ### #######  #######  #######  #######  ####### ");
            Console.WriteLine(" #####    ##  ##   ##  ##  ### ###            #####    ### ###  #####    #####   ######    #####    #####  ");
        }
        static void readMazeFromFile(char[,] maze)
        {
            StreamReader file = new StreamReader("maze.txt");
            string line;
            int row = 0;

            while ((line = file.ReadLine()) != null);
            {

                for (int i = 0; i < 121; i++)
                {
                    maze[row, i] = line[i];
                }
                row++;
            }
            file.Close();

        }
        static void options()
        {
            string option;
            while (true)

            {
                //SetConsoleTextAttribute(acolor, 11);
                Console.WriteLine("1)keys");
                Console.WriteLine("2)instructions");
                Console.WriteLine("3)Exit");
                Console.WriteLine("Enter your option");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    keys();
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    options();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    instructions();
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    options();
                }
                // else if (option == "3")
                // {
                //     system("cls");
                //     wholeGame();
                // }
            }
        }

      static void wholeGame()
        {
            string choice;
            //SetConsoleTextAttribute(acolor, 11);
            Console.WriteLine("1)Start");
            Console.WriteLine("2)Options");
            Console.WriteLine("3)Exit");
            Console.WriteLine("Enter your choice");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                bool runGame = true;
                Console.Clear();
                // game_name();
                // game_logo();
                Console.Clear();
                readMazeFromFile(maze);
                printMaze();
                printTank();
                printinkio();
                printredio();
                printtwinklo();
                printJake();
                while (runGame)
                {
                    moveJake(tankX, tankY);
                    printTankHealth();
                    printRedioHealth();
                    printInkioHealth();
                    printTwinkloHealth();
                    printScore();
                    if (Keyboard.IsKeyPressed(Key.LeftArrow))
                    {
                        moveTankLeft(maze);
                    }
                    if (Keyboard.IsKeyPressed(Key.RightArrow))
                    {
                        moveTankRight(maze);
                    }
                    if (Keyboard.IsKeyPressed(Key.UpArrow))
                    {
                        moveTankUp(maze);
                    }
                    if (Keyboard.IsKeyPressed(Key.DownArrow))
                    {
                        moveTankDown(maze);
                    }
                    if (Keyboard.IsKeyPressed(Key.Space))
                    {
                        generateBullet();
                    }

                    moveBullet();
                    playerCollisioWwithInkio();
                    playerCollisioWwithRedio();
                    playerCollisioWwithTwinklo();
                    bulletCollionWithinkio();
                    bulletCollionWithredio();
                    bulletCollionWithtwinklo();
                    bulletCollionWithtTank();
                    if (inkio_health != 0)
                    {
                        printinkio();
                        moveinkio(maze);
                        if (timer == 3)
                        {
                            generateinkioBullet();
                            timer = 0;
                        }
                        timer++;
                    }
                    else
                    {
                        eraseinkio();
                        enemyX = 150;
                        enemyY = 20;
                    }
                    if (redio_health != 0)
                    {
                        printredio();
                        moveredio(maze);
                        if (timer1 == 5)
                        {
                            generateredioBullet();
                            timer1 = 0;
                        }
                        timer1++;
                    }
                    else
                    {
                        eraseredio();
                        enemyA = 150;
                        enemyB = 20;
                    }
                    if (twinklo_health != 0)
                    {
                        printtwinklo();
                        movetwinklo(maze);
                        if (timer2 == 7)
                        {
                            generatetwinkloBullet();
                            timer2 = 0;
                        }
                        timer2++;
                    }
                    else
                    {
                        erasetwinklo();
                        enemyC = 150;
                        enemyD = 20;
                    }
                    if (twinklo_health == 0 && redio_health == 0 && inkio_health == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You won!");
                        Console.WriteLine("Enter any key to continue...");
                        Console.ReadKey();
                        //main();
                    }
                    if (player_health <= 0)
                    {
                        break;
                    }

                    moveredioBullet();
                    moveinkioBullet();
                    movetwinkloBullet();
                    Thread.Sleep(50);
                }
            }
            else if (choice == "2")
            {
                Console.Clear();
                options();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Exit");
                Thread.Sleep(30);//Sleep(30);
                Console.Clear();
            }
        }
    }
}
            
        

