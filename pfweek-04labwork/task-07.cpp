#include<iostream>
#include<windows.h>
using namespace std;

void gotoxy(int, int);
void printmaze();
void playmove(int x, int y);

main()
{
  system("cls");
  int x = 10;
  int y = 3;
  printmaze();

  while(true)
  {
    playmove(x,y);

    if (y<11)
    {
     y=y+1;
    }
    if (y==11)
    {
     gotoxy(x,y-1);
     cout<<"";
     y=3;
    }
  }
}

  void printmaze()
  {
   cout<<"###############################"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"#                             #"<<endl;
   cout<<"###############################"<<endl;
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
    gotoxy(x,y-1);
    cout<<" ";
    gotoxy(x,y);
    cout<<"p";
    Sleep(300);
    }