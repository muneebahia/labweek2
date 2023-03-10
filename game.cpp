#include <iostream>
#include <windows.h>
using namespace std;
void printMaze();
void printTank();
void printinkio();
void printredio();
void printtwinklo();

void moveTankDown();
void moveTankLeft();
void moveTankUp();
void moveTankRight();

void moveinkio();
void eraseinkio();
void moveredio();
void eraseredio();
void movetwinklo();
void erasetwinklo();

void generateBullet();
void moveBullet();
void printBullet(int x, int y);
void eraseBullet(int x, int y);
void makeBulletInactive(int idx);

void generateinkioBullet();
void moveinkioBullet();
void printinkioBullet(int x, int y);
void eraseinkioBullet(int x, int y);
void makeinkioBulletInactive(int idx);

void generateredioBullet();
void moveredioBullet();
void printredioBullet(int x, int y);
void eraseredioBullet(int x, int y);
void makeredioBulletInactive(int idx);

void generatetwinkloBullet();
void movetwinkloBullet();
void printtwinkloBullet(int x, int y);
void erasetwinkloBullet(int x, int y);
void maketwinkloBulletInactive(int idx);

void addScore();
void printScore();
void print_inkhealth();
void erase_health();

void gotoxy(int x, int y);
char getCharAtxy(short int x, short int y);
void bulletCollionWithinkio();
void bulletCollionWithredio();
void bulletCollionWithtwinklo();
void eraseTank();

int score = 0;
int timer = 3;
int timer1 = 5;
int timer2 = 7;
int inkiotimer = 0;
int rediotimer = 0;
int twinklotimer = 0;
int inkio_health = 100;

string inkioDirection = "Left";
string redioDirection = "Left";
string twinkloDirection = "Left";
// player character
char box = 219;
// char tank1[3] = {' ', ':', ' '};
char tank2[3] = {' ', ':', ' '};
char tank3[3] = {box, box, box};
char tank4[3] = {'0', ' ', '0'};
// enemy character
char enemy1[3] = {box, box, box};
char enemy2[3] = {' ', ':', ' '};
char enemy3[3] = {' ', ':', ' '};
// enemy character
char enemy4[3] = {box, box, box};
char enemy5[3] = {' ', ':', ' '};
char enemy6[3] = {' ', ':', ' '};
// enemy character
char enemy7[3] = {box, box, box};
char enemy8[3] = {' ', ':', ' '};
char enemy9[3] = {' ', ':', ' '};

// player coordinates
int tankX = 5;
int tankY = 20;
// coordinates of inkio
int enemyX = 4;
int enemyY = 4;
// coordinates of redio
int enemyA = 50;
int enemyB = 4;
// coordinates of TWINKLO
int enemyC = 90;
int enemyD = 4;

// global arrays and variables //
// player bullets
int bulletX[1000];
int bulletY[1000];
bool isBulletActive[1000];
int bulletCount = 0;

int inkiobulletX[1000];
int inkiobulletY[1000];
bool isinkioBulletActive[1000];
int inkiobulletCount = 0;

int rediobulletX[1000];
int rediobulletY[1000];
bool isredioBulletActive[1000];
int rediobulletCount = 0;

int twinklobulletX[1000];
int twinklobulletY[1000];
bool istwinkloBulletActive[1000];
int twinklobulletCount = 0;

main()
{
    system("cls");
    printMaze();
    printTank();
    printinkio();
    printredio();
    printtwinklo();

    while (true)
    {
        printScore();
        if (GetAsyncKeyState(VK_LEFT))
        {
            moveTankLeft();
        }
        if (GetAsyncKeyState(VK_RIGHT))
        {
            moveTankRight();
        }
        if (GetAsyncKeyState(VK_UP))
        {
            moveTankUp();
        }
        if (GetAsyncKeyState(VK_DOWN))
        {
            moveTankDown();
        }
        if (GetAsyncKeyState(VK_SPACE))
        {
            generateBullet();
        }
        if (timer == 3)
        {
            moveinkio();
            moveinkioBullet();
            // cout << timer;
            timer = 0;
        }
        if (timer1 == 5)
        {
            moveredio();
            moveredioBullet();
            timer1 = 0;
        }
        if (timer2 == 7)
        {
            movetwinklo();
            movetwinkloBullet();
            timer2 = 0;
        }

        moveBullet();
        bulletCollionWithinkio();
        bulletCollionWithredio();
        bulletCollionWithtwinklo();
        print_inkhealth();

        
        timer++;
        timer1++;
        timer2++;
        Sleep(30);
    }
}
void printMaze()
{
    cout << "#########################################################################################################################" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                     #                                         #                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#                                                                                                                       #" << endl;
    cout << "#########################################################################################################################" << endl;
}
void printTank()
{
    // gotoxy(tankX, tankY);
    // for (int idx = 0; idx < 3; idx++)
    // {
    //     cout << tank1[idx];
    // }
    gotoxy(tankX, tankY + 1);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << tank2[idx];
    }
    gotoxy(tankX, tankY + 2);

    for (int idx = 0; idx < 3; idx++)
    {
        cout << tank3[idx];
    }
    gotoxy(tankX, tankY + 3);

    for (int idx = 0; idx < 3; idx++)
    {
        cout << tank4[idx];
    }
}
void printinkio()
{
    gotoxy(enemyX, enemyY);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy1[idx];
    }

    gotoxy(enemyX, enemyY + 1);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy2[idx];
    }

    gotoxy(enemyX, enemyY + 2);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy3[idx];
    }
}
void printredio()
{
    gotoxy(enemyA, enemyB);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy4[idx];
    }

    gotoxy(enemyA, enemyB + 1);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy5[idx];
    }

    gotoxy(enemyA, enemyB + 2);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy6[idx];
    }
}
void printtwinklo()
{
    gotoxy(enemyC, enemyD);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy7[idx];
    }

    gotoxy(enemyC, enemyD + 1);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy8[idx];
    }

    gotoxy(enemyC, enemyD + 2);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << enemy9[idx];
    }
}

// CHARACTER MOVEMENT //
void moveTankLeft()
{
    char next = getCharAtxy(tankX - 1, tankY);
    if (next == ' ')
    {
        eraseTank();
        tankX = tankX - 1;
        printTank();
    }
}
void moveTankRight()
{
    char next = getCharAtxy(tankX + 6, tankY);
    if (next == ' ')
    {
        eraseTank();
        tankX = tankX + 1;
        printTank();
    }
}
void moveTankUp()
{
    char next = getCharAtxy(tankX, tankY - 1);
    if (next == ' ')
    {
        eraseTank();
        tankY = tankY - 1;
        printTank();
    }
}
void moveTankDown()
{
    char next = getCharAtxy(tankX, tankY + 4);
    if (next == ' ')
    {
        eraseTank();
        tankY = tankY + 1;
        printTank();
    }
}
void moveinkio()
{
    if (inkiotimer == 2)
    {
        generateinkioBullet();
        inkiotimer = 0;
    }
    inkiotimer++;
    if (inkioDirection == "Right")
    {
        char next = getCharAtxy(enemyX + 6, enemyY);
        if (next == ' ')
        {
            eraseinkio();
            enemyX++;
            printinkio();
        }
        else if (next == '#' || next == '.')
        {
            inkioDirection = "Left";
        }
    }
    if (inkioDirection == "Left")
    {
        char next = getCharAtxy(enemyX - 1, enemyY);
        if (next == ' ')
        {
            eraseinkio();
            enemyX--;
            printinkio();
        }
        if (next == '#' || next == '.')
        {
            inkioDirection = "Right";
        }
    }
}
void moveredio()
{
    if (rediotimer == 2)
    {
        generateredioBullet();
        rediotimer = 0;
    }
    rediotimer++;
    if (redioDirection == "Right")
    {
        char next = getCharAtxy(enemyA + 6, enemyB);
        if (next == ' ' || next == '.')
        {
            eraseredio();
            enemyA++;
            printredio();
        }
        else if (next == '#')
        {
            redioDirection = "Left";
        }
    }
    if (redioDirection == "Left")
    {
        char next = getCharAtxy(enemyA - 1, enemyB);
        if (next == ' ' || next == '.')
        {
            eraseredio();
            enemyA--;
            printredio();
        }
        if (next == '#')
        {
            redioDirection = "Right";
        }
    }
}
void movetwinklo()
{
    if (twinklotimer == 2)
    {
        generatetwinkloBullet();
        twinklotimer = 0;
    }
    twinklotimer++;
    if (twinkloDirection == "Right")
    {
        char next = getCharAtxy(enemyC + 6, enemyD);
        if (next == ' ')
        {
            erasetwinklo();
            enemyC++;
            printtwinklo();
        }
        else if (next == '#' || next == '.')
        {
            twinkloDirection = "Left";
        }
    }
    if (twinkloDirection == "Left")
    {
        char next = getCharAtxy(enemyC - 1, enemyD);
        if (next == ' ')
        {
            erasetwinklo();
            enemyC--;
            printtwinklo();
        }
        if (next == '#' || next == '.')
        {
            twinkloDirection = "Right";
        }
    }
}

void eraseinkio()
{
    gotoxy(enemyX, enemyY);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
    gotoxy(enemyX, enemyY + 1);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
    gotoxy(enemyX, enemyY + 2);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
}
void eraseredio()
{
    gotoxy(enemyA, enemyB);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
    gotoxy(enemyA, enemyB + 1);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
    gotoxy(enemyA, enemyB + 2);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
}
void erasetwinklo()
{
    generatetwinkloBullet();
    gotoxy(enemyC, enemyD);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
    gotoxy(enemyC, enemyD + 1);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
    gotoxy(enemyC, enemyD + 2);
    for (int idx = 0; idx < 3; idx++)
    {
        cout << " ";
    }
}

void eraseTank()
{
    // gotoxy(tankX, tankY);
    // for (int idx = 0; idx < 6; idx++)
    // {
    //     cout << " ";
    // }
    gotoxy(tankX, tankY + 1);
    for (int idx = 0; idx < 6; idx++)
    {
        cout << " ";
    }
    gotoxy(tankX, tankY + 2);
    for (int idx = 0; idx < 6; idx++)
    {
        cout << " ";
    }
    gotoxy(tankX, tankY + 3);
    for (int idx = 0; idx < 6; idx++)
    {
        cout << " ";
    }
}
void generateBullet()
{
    bulletX[bulletCount] = tankX;
    bulletY[bulletCount] = tankY - 1;
    isBulletActive[bulletCount] = true;
    gotoxy(tankX, tankY - 1);
    cout << ".";
    bulletCount++;
}
// move bullet
void moveBullet()
{
    for (int x = 0; x < bulletCount; x++)
    {
        if (isBulletActive[x] == true)
        {
            char next = getCharAtxy(bulletX[x], bulletY[x] - 1);
            if (next != ' ')
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
void printBullet(int x, int y)
{
    gotoxy(x, y);
    cout << ".";
}
void eraseBullet(int x, int y)
{
    gotoxy(x, y);
    cout << " ";
}
void makeBulletInactive(int idx)
{
    isBulletActive[idx] = false;
}
// collisionn detection
// collision with enemy
void bulletCollionWithinkio()
{
    for (int x = 0; x < bulletCount; x++)
    {
        if (isBulletActive[x] == true)
        {

            if (bulletX[x] == enemyX && (bulletY[x] - 1 == enemyY || bulletY[x] == enemyY + 2 || bulletY[x] == enemyY + 3))
            {
                addScore();
                inkio_health=inkio_health-2;
                //print_inkhealth();

            }
            if (enemyX - 1 == bulletX[x] && enemyY + 1 == bulletY[x])
            {
                addScore();
            }
        }
    }
}
void bulletCollionWithredio()
{
    for (int x = 0; x < bulletCount; x++)
    {
        if (isBulletActive[x] == true)
        {

            if (bulletX[x] == enemyA && (bulletY[x] - 1 == enemyB || bulletY[x] == enemyB + 2 || bulletY[x] == enemyB + 3))
            {
                addScore();
            }
            if (enemyA - 1 == bulletX[x] && enemyB + 1 == bulletY[x])
            {
                addScore();
            }
        }
    }
}
void bulletCollionWithtwinklo()
{
    for (int x = 0; x < bulletCount; x++)
    {
        if (isBulletActive[x] == true)
        {

            if (bulletX[x] == enemyC && (bulletY[x] - 1 == enemyD || bulletY[x] == enemyC + 2 || bulletY[x] == enemyD + 3))
            {
                addScore();
            }
            if (enemyC - 1 == bulletX[x] && enemyD + 1 == bulletY[x])
            {
                addScore();
            }
        }
    }
}

void generateinkioBullet()
{
    inkiobulletX[inkiobulletCount] = enemyX + 1;
    inkiobulletY[inkiobulletCount] = enemyY + 3;
    isinkioBulletActive[inkiobulletCount] = true;
    gotoxy(enemyX + 1, enemyY + 3);
    cout << "-";
    inkiobulletCount++;
}
void generateredioBullet()
{
    rediobulletX[rediobulletCount] = enemyA + 1;
    rediobulletY[rediobulletCount] = enemyB + 3;
    isredioBulletActive[rediobulletCount] = true;
    gotoxy(enemyA + 1, enemyB + 3);
    cout << "-";
    rediobulletCount++;
}
void generatetwinkloBullet()
{
    twinklobulletX[twinklobulletCount] = enemyC + 1;
    twinklobulletY[twinklobulletCount] = enemyD + 3;
    istwinkloBulletActive[twinklobulletCount] = true;
    gotoxy(enemyC + 1, enemyD + 3);
    cout << "-";
    twinklobulletCount++;
}

void moveinkioBullet()
{
    for (int x = 0; x < inkiobulletCount; x++)
    {
        if (isinkioBulletActive[x] == true)
        {
            char next = getCharAtxy(inkiobulletX[x], inkiobulletY[x] + 4);
            if (next != ' ')
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
void moveredioBullet()
{
    for (int x = 0; x < rediobulletCount; x++)
    {
        if (isredioBulletActive[x] == true)
        {
            char next = getCharAtxy(rediobulletX[x], rediobulletY[x] + 4);
            if (next != ' ')
            {
                eraseredioBullet(rediobulletX[x], rediobulletY[x]);
                makeredioBulletInactive(x);
            }
            else
            {
                eraseredioBullet(rediobulletX[x], rediobulletY[x]);
                rediobulletY[x] = rediobulletY[x] + 2;
                printredioBullet(rediobulletX[x], rediobulletY[x]);
            }
        }
    }
}
void movetwinkloBullet()
{
    for (int x = 0; x < twinklobulletCount; x++)
    {
        if (istwinkloBulletActive[x] == true)
        {
            char next = getCharAtxy(twinklobulletX[x], twinklobulletY[x] + 4);
            if (next != ' ')
            {
                erasetwinkloBullet(twinklobulletX[x], twinklobulletY[x]);
                maketwinkloBulletInactive(x);
            }
            else
            {
                erasetwinkloBullet(twinklobulletX[x], twinklobulletY[x]);
                twinklobulletY[x] = twinklobulletY[x] + 2;
                printtwinkloBullet(twinklobulletX[x], twinklobulletY[x]);
            }
        }
    }
}

void printinkioBullet(int x, int y)
{
    gotoxy(x, y);
    cout << "-";
}
void printredioBullet(int x, int y)
{
    gotoxy(x, y);
    cout << "-";
}
void printtwinkloBullet(int x, int y)
{
    gotoxy(x, y);
    cout << "-";
}

void eraseinkioBullet(int x, int y)
{
    gotoxy(x, y);
    cout << " ";
}
void eraseredioBullet(int x, int y)
{
    gotoxy(x, y);
    cout << " ";
}
void erasetwinkloBullet(int x, int y)
{
    gotoxy(x, y);
    cout << " ";
}

void makeinkioBulletInactive(int idx)
{
    isinkioBulletActive[idx] = false;
}
void makeredioBulletInactive(int idx)
{
    isredioBulletActive[idx] = false;
    //isinkioBulletActive[idx] = false;
}
void maketwinkloBulletInactive(int idx)
{
    istwinkloBulletActive[idx] = false;
}

// reward score
void addScore()
{
    score++;
}
void printScore()
{
    gotoxy(2, 28);
    cout << "score : " << score;
}
void print_inkhealth()
{
    if (inkio_health >= 0)
    {

        gotoxy(2, 30);
        cout << "inkio health is: " << inkio_health;
    }
}
void erase_health()
{
    gotoxy(2, 30);
    cout << "";
}

// supporting functions
char getCharAtxy(short int x, short int y)
{
    CHAR_INFO ci;
    COORD xy = {0, 0};
    SMALL_RECT rect = {x, y, x, y};
    COORD coordBufSize;
    coordBufSize.X = 1;
    coordBufSize.Y = 1;
    return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), &ci, coordBufSize, xy, &rect) ? ci.Char.AsciiChar : ' ';
}
void gotoxy(int x, int y)
{
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}
