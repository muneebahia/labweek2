#include <iostream>
#include <windows.h>
using namespace std;

void printmaze();
void gotoxy(int x , int y);
void clear(int x , int y, char previous);
void printghost1(int x, int y);
void printghost2(int x, int y);
char getCharAtxy(short int x, short int y);

main()
{
	int gx = 30;
	int gy = 6;
	int ga = 8;
	int gb = 5;
	string direction = "right";
	string direction1 = "down";
	char previous = ' ';
	char previous1 = ' ';
	bool gameRunning = true;

	system("cls");
	printmaze();
	printghost1(gx , gy);
	printghost2(ga, gb);


  while(gameRunning)
   {
	Sleep(200);
	
	if(direction == "right")
	{
	  char nextlocation =  getCharAtxy(gx + 1, gy);
	  if(nextlocation == '|'|| nextlocation == '%')
	  {
	       direction ="left";
	  }
	  else if(nextlocation == ' ' || nextlocation == '.')
	  {
		clear(gx , gy , previous);
		gx = gx + 1;
		previous = nextlocation;
		printghost1(gx , gy);
	  }

        }
	if(direction == "left")
	{
	  char nextlocation =  getCharAtxy(gx - 1, gy);
	  if(nextlocation == '|'|| nextlocation == '%')
	  {
	       direction ="right";
	  }
	  else if(nextlocation == ' ' || nextlocation == '.')
	  {
		clear(gx , gy , previous);
		gx = gx - 1;
		previous = nextlocation;
		printghost1(gx , gy);
	  }

         }
	if(direction1 == "down")
	{
	  char nextlocation =  getCharAtxy(ga, gb + 1);
	  if(nextlocation == '#' || nextlocation == '%' )
	  {
	       direction1 ="up";
	  }
	  else if(nextlocation == ' ' || nextlocation == '.')
	  {
		clear(ga , gb , previous1);
		gb = gb + 1;
		previous1 = nextlocation;
		printghost2(ga , gb);
	  }

        }
	if(direction1 == "up")
	{
	  char nextlocation =  getCharAtxy(ga, gb -1);
	  if(nextlocation == '#'|| nextlocation == '%')
	  {
	       direction1 ="down";
	  }
	  else if(nextlocation == ' ' || nextlocation == '.')
	  {
		clear(ga , gb , previous1);
		gb = gb - 1;
		previous1 = nextlocation;
		printghost2(ga , gb);
	  }

         }
     }
 }


void printmaze()
{

	  cout << " #######################################################################      " << endl;
    cout << " ||.. ......................................................  ......  ||          " << endl;
    cout << " ||.. %%%%%%%%%%%%%%%%        ...      %%%%%%%%%%%%%%  |%|..   %%%%   ||     " << endl;
    cout << " ||..        |%|   |%|     |%|...      |%|        |%|  |%|..    |%|   ||         " << endl;
    cout << " ||..        |%|   |%|     |%|...      |%|        |%|  |%|..    |%|   ||          " << endl;
    cout << " ||..        %%%%%%%%  . . |%|...      %%%%%%%%%%%%%%     ..   %%%%.  ||     " << endl;
    cout << " ||..        |%|       . . |%|...     ............... |%| ..       .  ||        " << endl;
    cout << " ||..        %%%%%%%%%%. . |%|...     %%%%%%%%%%%%    |%| ..   %%%%.  ||        " << endl;
    cout << " ||..               |%|.              |%|......       |%| ..    |%|.  ||       " << endl;
    cout << " ||..     ......... |%|.              |%|......|%|        ..    |%|.  ||      " << endl;
    cout << " ||..|%|  |%|%%%|%|.|%|.  |%|            ......|%|        ..|%| |%|.  ||        " << endl;
    cout << " ||..|%|  |%|   |%|..     %%%%%%%%%%%%%  ......|%|         .|%|.      ||       " << endl;
    cout << " ||..|%|  |%|   |%|..            ...|%|     %%%%%%        . |%|.      ||       " << endl;
    cout << " ||..|%|           .             ...|%|               |%| ..|%|.      ||      " << endl;
    cout << " ||..|%|  %%%%%%%%%%%%%%         ...|%|%%%%%%%%%%     |%| ..|%|%%%%%  ||   " << endl;
    cout << " ||................................................   |%| ..........  ||    " << endl;
    cout << " ||   .............................................          .......  ||    " << endl;
    cout << " ||..|%|  |%|   |%|..    %%%%%%%%%%%%%  ......|%|     |%| ..|%|.      ||    " << endl;
    cout << " ||..|%|  |%|   |%|..           ...|%|     %%%%%%     |%| ..|%|.      ||    " << endl;
    cout << " ||..|%|            .           ...|%|                |%| ..|%|.      ||     " << endl;
    cout << " ||..|%|  %%%%%%%%%%%%%%        ...|%|%%%%%%%%%%      |%| ..|%|%%%%%  ||  " << endl;
    cout << " ||...............................................    |%| ..........  ||    " << endl;
    cout << " ||...............................................           .......  ||   " << endl;
    cout << " #######################################################################      " << endl;
}


void printghost1(int x, int y)
{
	gotoxy(x , y);
	cout << "G";
}
void printghost2(int x, int y)
{
	gotoxy(x , y);
	cout << "V";
}

void clear(int x, int y ,char previous)
{
	gotoxy(x , y);
	cout << previous;
}

void gotoxy(int x , int y)
{
	COORD coordinates;
	coordinates.X = x;
	coordinates.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}
char getCharAtxy(short int x, short int y)
{
	CHAR_INFO ci;
	COORD xy = {0 , 0};
	SMALL_RECT rect = {x, y, x, y};
	COORD coordBufSize;
	coordBufSize.X = 1;
	coordBufSize.Y = 1;
	return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), & ci, coordBufSize, xy, & rect) ? ci.Char.AsciiChar : ' ';
}