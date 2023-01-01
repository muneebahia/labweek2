#include<iostream>
using namespace std;

void sleepwell(int offday);

main()
{
 int offday;
 cout<<"enter offday";
 cin>>offday;

 sleepwell (offday);
}
  void sleepwell(int offday)
  {
   int totaldaysiy,workingd,holidays,gamingtime,Nsleepingt,differencefn;
    Nsleepingt=30000;  
    workingd=totaldaysiy+holidays;
    gamingtime=(workingd*63)+(holidays*127);
    differencefn=30000-gamingtime;
    cout<<"difference from the normal sleep is:"<<differencefn<<endl;

    if(differencefn<30000)
    {
     cout<<"the tom cannot sleep well:";
     }

   }