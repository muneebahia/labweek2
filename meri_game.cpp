#include <iostream>
#include <windows.h>
#include <fstream>
#include <conio.h>
using namespace std;
HANDLE acolor=GetStdHandle(STD_OUTPUT_HANDLE);
void printMaze();
void printTank();
void printinkio();
void printredio();
void printtwinklo();
void readMazeFromFile();

void printJake();
void moveJake(int x, int y);
void eraseJake();

void moveTankDown();
void moveTankLeft();
void moveTankUp();
void moveTankRight();
void printTankHealth();
void eraseTankHealth();

void moveinkio();
void eraseinkio();
void printInkioHealth();
void eraseInkioHealth();

void moveredio();
void eraseredio();
void printRedioHealth();
void eraseRedioHealth();

void movetwinklo();
void erasetwinklo();
void printTwinkloHealth();
void eraseTwinkloHealth();

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
void gotoxy(int x, int y);
char getCharAtxy(short int x, short int y);
void bulletCollionWithinkio();
void bulletCollionWithredio();
void bulletCollionWithtwinklo();
void bulletCollionWithtTank();

void playerCollisioWwithInkio();
void playerCollisioWwithRedio();
void playerCollisioWwithTwinklo();

void wholeGame();
void options();
string choice;
void keys();
void instructions();
void game_name();
void game_logo();

void eraseTank();

int score = 0;
int timer = 3;
int timer1 = 5;
int timer2 = 7;
int inkiotimer = 0;
int rediotimer = 0;
int twinklotimer = 0;
int inkio_health = 50;
int redio_health = 70;
int twinklo_health = 80;
int player_health = 50;

char body = 254;
char arm = 45;

string inkioDirection = "Left";
string redioDirection = "Left";
string twinkloDirection = "Left";
// player character
char box = 219;
char tank[3][3] = {{'.', ':', '.'},
                   {box, box, box},
                   {'0', ' ', '0'}};
// enemy character
char enemy1[3][3] = {{box, box, box},
                     {' ', ':', ' '},
                     {' ', ':', ' '}};
char enemy2[3][3] = {{box, box, box},
                     {' ', ':', ' '},
                     {' ', ':', ' '}};
// enemy character
char enemy3[3][3] = {{box, box, box},
                     {' ', ':', ' '},
                     {' ', ':', ' '}};

char Jake[3][3] = {{' ', '|', ' '},
                   {arm, body, arm},
                   {' ', '|', ' '}};
char maze1[26][121];
// player coordinates
int tankX = 5;
int tankY = 20;
// coordinates of inkio
int enemyX = 4;
int enemyY = 2;
// coordinates of redio
int enemyA = 50;
int enemyB = 2;
// coordinates of TWINKLO
int enemyC = 90;
int enemyD = 2;
// coordinates of Jake
int JakeX = 10;
int JakeY = 10;

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
    game_name();
     game_logo();
    wholeGame();
}
void printMaze()
{ SetConsoleTextAttribute(acolor,14);
    for (int i = 0; i < 26; i++)
    {
        for (int j = 0; j < 121; j++)
        {
            cout << maze1[i][j];
        }
        cout << endl;
    }
}
void game_logo()
{    SetConsoleTextAttribute(acolor,2);
    cout<<"                                                                                         ----.  -== "<< endl;
    cout<<"                                                                                      .:=*       .* "<< endl;
    cout<<"                                                                                 :----:  += :----.  "<< endl;
    cout<<"                                           ::::::::::::::::::             .:----:..:::::: .:.       "<< endl;
    cout<<"                                         -=                  =.      .----:  .----:                 "<< endl;
    cout<<"                                        :=                    *:--:::..::::::.                      "<< endl;
    cout<<"                                        *                     .+ .----:                             "<< endl;
    cout<<"                          --:::::::::+  #                      #-.                                  "<< endl;
    cout<<"                          *          +. *                      *                                    "<< endl;
    cout<<"                        .:#          +-:+::::::::::::::::::::::+:::-:                               "<< endl;
    cout<<"                       +: *          +.                              =-                             "<< endl;
    cout<<"                      =   .:::::::::::                                .+.                           "<< endl;
    cout<<"                     *                                                  *.                          "<< endl;
    cout<<"                  .:==:::::::::::::::::::::::::::------::::::::::----:::-+:::                       "<< endl;
    cout<<"                -=:                                                          -=                     "<< endl;
    cout<<"              :=  :--=+=------+++--------=*+---------=+++---:::--=++---=.  +.                       "<<endl;
    cout<<"             =:.=-.=-. .-=  -=.    .=-   ---.  .:-=.  ---.  .:-=   =-. .:-: :+  =:                  "<< endl;
    cout<<"            :  =: :-     -=:=        =- *          +.+:         * +.      =  *                      "<< endl;
    cout<<"                ==.+     +.::        :=.=          .-#          -::+     .=-=                       "<< endl;
    cout<<"                  -==---   +:      :+  +:        . :+        -+   ----+*=                           "<< endl;
    cout<<"                     ::-::-::++==---:    :--::::---    --::::-=:::::-::-:                           "<< endl;
    cout<<"                                .:----------------------------::.                                   "<< endl;
    cout << "Press any key to continue" << endl;
    getch();
}

void game_name()
{ SetConsoleTextAttribute(acolor,11);
    cout<<"######     ###    ##  ##   ### ###           ######   ######    #####    ##  ##  ######    ###     ######  "<< endl;
    cout<<" ######   #####   ### ###   ## ###            ######  ### ###  ### ###  ### ###   ## ###   ###      ###### "<< endl;
    cout<<"  ###    ### ###  ### ###   #####              ###    ###  ##  ### ###  ### ###   ## ###   ###      ##     "<< endl;
    cout<<"  ###    ### ###  #### ##  #####               ###    ### ###  ##   ##  ##  ###   #####   ###      ######  "<< endl;
    cout<<"  ###    ### ###  ## ####  ####                ###    ######   ##   ##  ###  ##  ### ##   ###      #####   "<< endl;
    cout<<"  ###    #######  ### ###  ######              ###    ### ###  ### ###  ### ###  ### ###  ### ###  ###     "<< endl;
    cout<<"  ###    ### ###  ### ###  ### ###             ###     ### ### #######  #######  #######  #######  ####### "<< endl;
    cout<<" #####    ##  ##   ##  ##  ### ###            #####    ### ###  #####    #####   ######    #####    #####  "<< endl;
}
void options()
{
    string option;
    while (option != "3")
    { SetConsoleTextAttribute(acolor,11);
        cout << "1)keys" << endl;
        cout << "2)instructions" << endl;
        cout << "3)Exit" << endl;
        cout << "Enter your option" << endl;
        cin >> option;

        if (option == "1")
        {
            system("cls");
            keys();
            cout << endl;
            cout << "Press any key to continue";
            getch();
            system("cls");
            options();
        }
        else if (option == "2")
        {
            system("cls");
            instructions();
            cout << endl;
            cout << "Press any key to continue";
            getch();
            system("cls");
            options();
        }
        // else if (option == "3")
        // {
        //     system("cls");
        //     wholeGame();
        // }
    }
}
void wholeGame()
{ SetConsoleTextAttribute(acolor,11);
    cout << "1)Start" << endl;
    cout << "2)Options" << endl;
    cout << "3)Exit" << endl;
    cout << "Enter your choice" << endl;
    cin >> choice;

    if (choice == "1")
    {
        bool runGame = true;
        system("cls");
        // game_name();
        // game_logo();
        system("cls");
        readMazeFromFile();
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
                moveinkio();
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
                moveredio();
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
                movetwinklo();
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
                system("cls");
                cout << "You won!" << endl;
                cout << "Enter any key to continue...";
                getch();
                main();
            }
            if (player_health <= 0)
            {
                break;
            }

            moveredioBullet();
            moveinkioBullet();
            movetwinkloBullet();
            Sleep(50);
        }
    }
    else if (choice == "2")
    {
        system("cls");
        options();
    }
    else if (choice == "3")
    {
        cout << "Exit" << endl;
        Sleep(30);
        system("cls");
    }
}
void keys()
{ SetConsoleTextAttribute(acolor,14);
    cout<<" ##    ## ######## ##    ##  ###### "<<endl; 
    cout<<" ##   ##  ##        ##  ##  ##    ##"<<endl; 
    cout<<" ##  ##   ##         ####   ##      "<<endl; 
    cout<<" #####    ######      ##     ###### "<<endl; 
    cout<<" ##  ##   ##          ##          ##"<<endl; 
    cout<<" ##   ##  ##          ##    ##    ##"<<endl; 
    cout<<" ##    ## ########    ##     ###### "<<endl; 
    cout<<endl;
    cout<<endl;
    cout<<endl;
     SetConsoleTextAttribute(acolor,14);
    cout << "Press up key to move up" << endl;
    cout << "Press down key to move " << endl;
    cout << "Press left key to move left" << endl;
    cout << "Press right key to move right" << endl;
    cout << "Press space key to shoot" << endl;
}
void instructions()
{ SetConsoleTextAttribute(acolor,14);
  cout<<"####   ###  ##   ## ##   #### ##  ### ##   ##  ###   ## ##   #### ##    ####    ## ##   ###  ##   ## ## "<<endl;  
  cout<<" ##      ## ##  ##   ##  # ## ##   ##  ##  ##   ##  ##   ##  # ## ##     ##    ##   ##    ## ##  ##   ##"<<endl;  
  cout<<" ##     # ## #  ####       ##      ##  ##  ##   ##  ##         ##        ##    ##   ##   # ## #  ####   "<<endl;  
  cout<<" ##     ## ##    #####     ##      ## ##   ##   ##  ##         ##        ##    ##   ##   ## ##    ##### "<<endl;  
  cout<<" ##     ##  ##      ###    ##      ## ##   ##   ##  ##         ##        ##    ##   ##   ##  ##      ###"<<endl;  
  cout<<" ##     ##  ##  ##   ##    ##      ##  ##  ##   ##  ##   ##    ##        ##    ##   ##   ##  ##  ##   ##"<<endl;  
  cout<<"####   ###  ##   ## ##    ####    #### ##   ## ##    ## ##    ####      ####    ## ##   ###  ##   ## ## "<<endl;  
    cout<<endl;
    cout<<endl;
    cout<<endl;
 SetConsoleTextAttribute(acolor,14);
    cout << "1.shoot the enemies to get extra point" << endl;
    cout << "2.Hit the enemies to get the power" << endl;
    cout << "3.kill all the enemies to win the game" << endl;
    cout << "4.save your player from the bullets of enemies" << endl;
    cout << "5.the power of player decrease if the bullet from the enemy side hits the player" << endl;
    cout << "6.the power of enemy decrease if the bullet from the player side hits the enemy" << endl;
    cout << "7.the enemy is killed by the player if the power of enemies reduces to zero " << endl;
    cout << "8.If the bullet from the player hits the enemy the score and power increase " << endl;
}

void printTank()
{ SetConsoleTextAttribute(acolor,2);
    for (int idx = 0; idx < 3; idx++)
    {
        gotoxy(tankX, tankY + idx);
        for (int j = 0; j < 3; j++)
        {
            cout << tank[idx][j];
        }
        cout << endl;
    }
}
void readMazeFromFile()
{
    fstream file;
    string line;
    int j = 0;
    file.open("maze (2).txt", ios::in);
    while (!file.eof())
    {
        getline(file, line);
        for (int i = 0; i < 121; i++)
        {
            maze1[j][i] = line[i];
        }
        j++;
    }
    file.close();
    j = 0;
}
void printinkio()
{ SetConsoleTextAttribute(acolor,5);
    for (int i = 0; i < 3; i++)
    {
        gotoxy(enemyX, enemyY + i);
        for (int idx = 0; idx < 3; idx++)
        {
            cout << enemy1[i][idx];
        }
        cout << endl;
    }
}
void printredio()
{ SetConsoleTextAttribute(acolor,4);
    for (int i = 0; i < 3; i++)
    {
        gotoxy(enemyA, enemyB + i);
        for (int idx = 0; idx < 3; idx++)
        {
            cout << enemy2[i][idx];
        }
        cout << endl;
    }
}
void printtwinklo()
{ SetConsoleTextAttribute(acolor,6);
    for (int i = 0; i < 3; i++)
    {
        gotoxy(enemyC, enemyD + i);
        for (int idx = 0; idx < 3; idx++)
        {
            cout << enemy3[i][idx];
        }
        cout << endl;
    }
}

// CHARACTER MOVEMENT //
void moveTankLeft()
{
    char next = getCharAtxy(tankX - 2, tankY);
    char next1 = getCharAtxy(tankX - 2, tankY + 1);
    char next2 = getCharAtxy(tankX - 2, tankY + 2);
    if (next == ' ' && next1 == ' ' && next2 == ' ')
    {
        eraseTank();
        tankX = tankX - 1;
        printTank();
    }
}

void moveTankRight()
{
    char next = getCharAtxy(tankX + 3, tankY);
    char next1 = getCharAtxy(tankX + 3, tankY + 1);
    char next2 = getCharAtxy(tankX + 3, tankY + 2);
    if (next == ' ' && next1 == ' ' && next2 == ' ')
    {
        eraseTank();
        tankX = tankX + 1;
        printTank();
    }
}
void moveTankUp()
{
    char next = getCharAtxy(tankX, tankY - 1);
    char next1 = getCharAtxy(tankX + 1, tankY - 1);
    char next2 = getCharAtxy(tankX + 2, tankY - 1);
    if (next == ' ' && next1 == ' ' && next2 == ' ')
    {
        eraseTank();
        tankY = tankY - 1;
        printTank();
    }
}
void moveTankDown()
{
    char next = getCharAtxy(tankX, tankY + 4);
    char next1 = getCharAtxy(tankX + 1, tankY + 4);
    char next2 = getCharAtxy(tankX + 2, tankY + 4);
    if (next == ' ' && next1 == ' ' && next2 == ' ')
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
    for (int idx = 0; idx < 3; idx++)
    {
        for (int i = 0; i < 3; i++)
        {
            gotoxy(enemyX + idx, enemyY + i);
            cout << " ";
        }
    }
}
void eraseredio()
{
    for (int idx = 0; idx < 3; idx++)
    {
        for (int i = 0; i < 3; i++)
        {
            gotoxy(enemyA + idx, enemyB + i);
            cout << " ";
        }
    }
}
void erasetwinklo()
{
    for (int idx = 0; idx < 3; idx++)
    {
        for (int i = 0; i < 3; i++)
        {
            gotoxy(enemyC + idx, enemyD + i);
            cout << " ";
        }
    }
}

void eraseTank()
{
    for (int idx = 0; idx < 3; idx++)
    {
        for (int i = 0; i < 3; i++)
        {
            gotoxy(tankX + i, tankY + idx);
            cout << " ";
        }
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
{ SetConsoleTextAttribute(acolor,2);
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
void bulletCollionWithredio()
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
void bulletCollionWithtwinklo()
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
            char next = getCharAtxy(inkiobulletX[x], inkiobulletY[x] + 1);
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
            char next = getCharAtxy(rediobulletX[x], rediobulletY[x] + 1);
            if (next != ' ')
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
void movetwinkloBullet()
{
    for (int x = 0; x < twinklobulletCount; x++)
    {
        if (istwinkloBulletActive[x] == true)
        {
            char next = getCharAtxy(twinklobulletX[x], twinklobulletY[x] + 1);
            if (next != ' ')
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

void printinkioBullet(int x, int y)
{ SetConsoleTextAttribute(acolor,5);
    gotoxy(x, y);
    cout << "-";
}
void printredioBullet(int x, int y)
{ SetConsoleTextAttribute(acolor,4);
    gotoxy(x, y);
    cout << "-";
}
void printtwinkloBullet(int x, int y)
{ SetConsoleTextAttribute(acolor,6);
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
    // isinkioBulletActive[idx] = false;
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
void printInkioHealth()
{ SetConsoleTextAttribute(acolor,1);
    gotoxy(2, 30);
    cout << "Inkio Health:" << inkio_health;
}
void printRedioHealth()
{ SetConsoleTextAttribute(acolor,4);
    gotoxy(2, 31);
    cout << "Redio Health:" << redio_health;
}
void printTwinkloHealth()
{ SetConsoleTextAttribute(acolor,6);
    gotoxy(2, 32);
    cout << "Twinklo Health:" << twinklo_health;
}
void eraseInkioHealth()
{
    inkio_health = inkio_health - 5;
    if (inkio_health >= 0)
    {
        gotoxy(3, 30);
        cout << inkio_health;
    }
}
void eraseRedioHealth()
{
    redio_health = redio_health - 5;
    if (redio_health >= 0)
    {
        gotoxy(3, 31);
        cout << redio_health;
    }
}
void eraseTwinkloHealth()
{
    twinklo_health = twinklo_health - 5;
    if (twinklo_health >= 0)
    {
        gotoxy(3, 32);
        cout << twinklo_health;
    }
}
void printTankHealth()
{ SetConsoleTextAttribute(acolor,2);
    gotoxy(2, 29);
    cout << "Player Health:" << player_health;
}
void eraseTankHealth()
{
    player_health = player_health - 1;
    gotoxy(2, 29);
    cout << player_health;
}
void bulletCollionWithtTank()
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
void playerCollisioWwithInkio()
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
void playerCollisioWwithRedio()
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
void playerCollisioWwithTwinklo()
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
void printJake()
{   SetConsoleTextAttribute(acolor,11);
    for (int i = 0; i < 3; i++)
    {
        gotoxy(JakeX, JakeY + i);
        for (int j = 0; j < 3; j++)
        {
            cout << Jake[i][j];
        }
        cout << endl;
    }
}
void eraseJake()
{
    for (int i = 0; i < 3; i++)
    {
        gotoxy(JakeX, JakeY + i);
        for (int j = 0; j < 3; j++)
        {
            cout << " ";
        }
        cout << endl;
    }
}
void moveJake(int x, int y)
{
    char next;

    if (x > JakeX && y > JakeY)
    {
        next = getCharAtxy(JakeX, JakeY + 2);
        if (next == ' ' && JakeY < 14)
        {
            eraseJake();
            JakeY++;
            printJake();
        }
        next = getCharAtxy(JakeX + 3, JakeY);
        if (next == ' ')
        {
            eraseJake();
            JakeX++;
            printJake();
        }
    }
    else if (x == JakeX && y > JakeY)
    {
        next = getCharAtxy(JakeX, JakeY + 2);
        if (next == ' ' && JakeY < 14)
        {
            eraseJake();
            JakeY++;
            printJake();
        }
    }
    else if (x < JakeX && y > JakeY)
    {
        next = getCharAtxy(JakeX, JakeY + 2);
        if (next == ' ' && JakeY < 14)
        {
            eraseJake();
            JakeY++;
            printJake();
        }
        next = getCharAtxy(JakeX - 1, JakeY);
        if (next == ' ')
        {
            eraseJake();
            JakeX--;
            printJake();
        }
    }
    else if (x > JakeX && y < JakeY)
    {
        next = getCharAtxy(JakeX, JakeY-1);
        if (next == ' ' && JakeY < 14)
        {
            eraseJake();
            JakeY++;
            printJake();
        }
    }
    else
    {
        next = getCharAtxy(JakeX, JakeY-1);
        if (next == ' ' && JakeY<14)
        {
            eraseJake();
            JakeY--;
            printJake();
        }
    }
}