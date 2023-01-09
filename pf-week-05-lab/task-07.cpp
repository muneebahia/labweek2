#include <iostream>
#include<cmath>
using namespace std;
float percentage(float volume,float po,float pt,float hours);
float overflow(float volume,float po,float pt,float hours);

main()
{
 float volume,po,pt,hours;
 cout<<"enter volume:";
 cin>>volume;

 cout<<"enter p1:";
 cin>>po;

 cout<<"enter p2:";
 cin>>pt;

 cout<<"enter hours:";
 cin>>hours;

 percentage(volume,po,pt,hours);
}


float percentage(float volume,float po,float pt,float hours)
{

 float  ponafterthours, ptwafterthours,result1,percentageopo,percentageopt,volumeper,res;
 result1=ponafterthours+ ptwafterthours;
 if(result1<volume)
{

 ponafterthours=po*hours;
 ptwafterthours=pt*hours; 
 result1=ponafterthours+ ptwafterthours;
 
 percentageopo=(ponafterthours/result1)*100;
 
 res=floor(percentageopo);
 cout<<"pipe one contribution is:"<<res<<endl;
 percentageopt=(ptwafterthours/result1)*100;

 res=floor(percentageopt);
 cout<<"contribution of p2 is:"<<res<<endl;
 volumeper=(result1/volume)*100;
 cout<<"volume of pool is:"<<volumeper<<endl;

 }
  

 if(result1>volume)
 {
 
 float ponafterthours=po*hours;
 float ptwafterthours=pt*hours; 

 float result1=ponafterthours+ ptwafterthours;

  float overflow=result1-volume;
  cout<<"overflow"<<overflow<<endl;
}
}
  


