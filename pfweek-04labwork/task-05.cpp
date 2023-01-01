#include<iostream>
#include<windows.h>
using namespace std;
void printM();
void printU();
void printN();
void printE();
void printB();
void printA();

  void gotoxy(int x,int y)
   {
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
   }
main()
{
  system("cls");

  printM();
  
  printU();
  

  printN();
  

  printE();
  

  printE();
  

  printB();
  

  printA();
  


}

void printM()
{
  cout<<"**         **"<<endl;
  cout<<"** *     * **"<<endl;                             
  cout<<"**  *   *  **"<<endl;                               
  cout<<"**   * *   **"<<endl;                           
  cout<<"**    *    **"<<endl;                                      
  cout<<"**         **"<<endl;                                     
  cout<<"**         **"<<endl;                                      
  
}
 
void printU()
{
 
 cout<<"*         *"<<endl;
 cout<<"*         *"<<endl;
 cout<<"*         *"<<endl;
 cout<<"*         *"<<endl;
 cout<<"*         *"<<endl;
 cout<<"*         *"<<endl;
 cout<<" *********"<<endl;
 }

void printN()
{
 

 cout<<"**       **"<<endl;
 cout<<"** *     **"<<endl;
 cout<<"**  *    **"<<endl;
 cout<<"**   *   **"<<endl;
 cout<<"**    *  **"<<endl;
 cout<<"**     * **"<<endl;
 cout<<"**       **"<<endl;

}
  void printE()
{

 cout<<"*******"<<endl;
 cout<<"**     "<<endl; 
 cout<<"**     "<<endl;
 cout<<"*******"<<endl;
 cout<<"**     "<<endl;
 cout<<"**     "<<endl;
 cout<<"*******"<<endl;
}
 void printB()
{

 cout<<"****** "<<endl;
 cout<<"**    *"<<endl;
 cout<<"**    *"<<endl;
 cout<<"*****  "<<endl;
 cout<<"**    *"<<endl;
 cout<<"**    *"<<endl;
 cout<<"****** "<<endl;
}
 void printA()
{

 cout<<" *** "<<endl;
 cout<<"*   *"<<endl;
 cout<<"*   *"<<endl;
 cout<<"*****"<<endl;
 cout<<"*   *"<<endl;
 cout<<"*   *"<<endl;
}

