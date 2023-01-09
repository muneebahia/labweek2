#include<iostream>
#include<windows.h>
using namespace std;

void gotoxy(int, int);
void printgrid();
void playmove(int x, int y);

main()
{
  system("cls");
  int x = 3;
  int y = 15;
  printgrid();

  while(true)
  {
    playmove(x,y);

    if (x<64)
    {
     x=x+1;
    }
    if (x==64)
    {
     gotoxy(x-1,y);
     cout<<"";
     x=3;
    }
  }
}

void printgrid()
{
cout<<"######################################################################################"<<endl;
cout<<"||.. .............................................................     ......       ||"<<endl;
cout<<"||.. &&&&&&&&&&&&&&&&&&&&&         ...      &&&&&&&&&&&&&&   |&|..     &&&&&        ||"<<endl;
cout<<"||..            |&|     |&|     |&|...      |&|        |&|   |&|..      |&|         ||"<<endl;
cout<<"||..            |&|     |&|     |&|...      |&|        |&|   |&|..      |&|         ||"<<endl;
cout<<"||..            &&&&&&&&&&  . . |&|...      &&&&&&&&&&&&&&      ..     &&&&&.       ||"<<endl;
cout<<"||..            |&|         . . |&|...     .................|&| ..                  ||"<<endl;
cout<<"||..            &&&&&&&&&&&&. . |&|...     &&&&&&&&&&&&     |&| ..     &&&&&.       ||"<<endl;
cout<<"||..                     |&|.              |&|.......       |&| ..       |&|.       ||"<<endl;
cout<<"||..          .........  |&|.        P     |&|.......|&|        ..       |&|.       ||"<<endl;
cout<<"||..|&|       |&|&&&|&|. |&|. |&|             .......|&|        ..|&|    |&|.       ||"<<endl;
cout<<"||..|&|       |&|   |&|..     &&&&&&&&&&&&&&&  ......|&|         .|&|               ||"<<endl;
cout<<"||..|&|       |&|   |&|..              ...|&|    &&&&&&&        . |&|               ||"<<endl;
cout<<"||..|&|                 .              ...|&|               |&| ..|&|               ||"<<endl;
cout<<"||..|&|       &&&&&&&&&&&&&&&          ...|&|&&&&&&&&&&&&&  |&| ..|&|&&&&&&&        ||"<<endl;
cout<<"||..........................................................|&| .............       ||"<<endl;
cout<<"||.    .....................................................      ...........       ||"<<endl;
cout<<"||..|&|       |&|    |&|..    &&&&&&&&&&&&&&&  .......|&|    |&|  ..|&|             ||"<<endl;
cout<<"||..|&|       |&|    |&|..             ...|&|    &&&&&&&&    |&|  ..|&|             ||"<<endl;
cout<<"||..|&|                  .    G        ...|&|                |&|  ..|&|             ||"<<endl;
cout<<"||..|&|       &&&&&&&&&&&&&&&          ...|&|&&&&&&&&&&&&&   |&|  ..|&|             ||"<<endl;
cout<<"||.......................................................... |&|  ...........       ||"<<endl;
cout<<"||..........................................................         ........       ||"<<endl;
cout<<"||..                                                                                ||"<<endl;
cout<<"######################################################################################"<<endl;                         

}
   void gotoxy(int x,int y)
   {
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
   }
   
    void playmove(int x, int y)
    {
    gotoxy(x-1,y);
    cout<<" ";
    gotoxy(x,y);
    cout<<"p";
    Sleep(300);
    }