#include<iostream>
using namespace std;

void challan(int speed);
main()
{
 while(true)
 {
 int speed;
 cout<<"enter speed";
 cin>>speed;

 challan(speed);
  }
}
void challan(int speed)
 {
  if(speed<100)
  {
   cout<<"you are going good";
   }
 
   if(speed>=105)
   {
    cout<<"you will be challaned";
   }
  }