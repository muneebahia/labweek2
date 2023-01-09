#include<iostream>
using namespace std;

main()
{
 int hours,min,add;
 cout<<"enter hours:";
 cin>>hours;
 cout<<"enter min:";
 cin>>min;

 add=min+15;

 if(add<=59)
 {
  cout<<"the present time is:"<<hours<<"hour and"<<add<<"minutes"<<endl;
 }

  if(add>59)
  {
    hours=hours+1;
    cout<<"hours are:"<<hours<<endl;
    min=add-60;
    cout<<"time is:"<<min<<endl;
  }

  if(hours==24)
  {
  hours=00;
  cout<<"hours are:"<<hours<<endl;
  min=add-60;
  cout<<"time is:"<<min<<endl;
  }

}