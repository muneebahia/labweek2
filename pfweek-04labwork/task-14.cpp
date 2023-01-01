#include<iostream>
#include <windows.h>
using namespace std;
void gotoxy(int x,int y);
void printname();

main()
{
 int x = 3;
 int y = 3;
 printname();
}

   void printname()
  {
    system ("cls");
    gotoxy(30,20);
    cout<<"##             ##  ##     ##  ###      ##  ####### #######  ######     ###    "<<endl;
    gotoxy(30,21);
    cout<<"## #         # ##  ##     ##  ## #     ##  ##      ##       ##    #  ##   ##  "<<endl;
    gotoxy(30,22);
    cout<<"##  #       #  ##  ##     ##  ##  #    ##  ##      ##       ##    #  ##   ##  "<<endl;
    gotoxy(30,23);
    cout<<"##   #     #   ##  ##     ##  ##   #   ##  ####### #######  ######   #######  "<<endl;
    gotoxy(30,24);
    cout<<"##    #   #    ##  ##     ##  ##    #  ##  ##      ##       ##    #  ##   ##  "<<endl;
    gotoxy(30,25);
    cout<<"##     # #     ##  ##     ##  ##     # ##  ##      ##       ##    #  ##   ##  "<<endl;
    gotoxy(30,26);
    cout<<"##      #      ##   #######   ##      ###  ####### #######  ######   ##   ##  "<<endl;
}
   void gotoxy(int x,int y)
   {
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
   }
