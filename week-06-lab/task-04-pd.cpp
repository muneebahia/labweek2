#include <iostream>
using namespace std;

float ammount(char code,float numofmin);

main()
{
    char code;
    float numofmin,result;
    string time;
    cout<<"enter service code";
    cin>>code;

    cout<<"enter number of minuts";
    cin>>numofmin;
    result = ammount(code,numofmin);
    cout<<" payable ammount is:"<<result<<endl;


}
float ammount(char code,float numofmin)
{  
    string time;
    float leftmin,rate;
    if(code=='r' && numofmin>50)
    { 
        
    leftmin = numofmin-50;
    rate = leftmin*0.02;
    }

    if(code=='r' && numofmin<=50)
    { 
        
      rate==0;
    }
     
     if(code=='p')
     {
      cout<<"enter time";
      cin>>time;
      if(time=="day" && numofmin>75)
      {
      leftmin = numofmin-75;
      rate = leftmin*0.10;

      }

      if(time=="day" && numofmin<=75)
      {
      
      rate = 25;

      }


     if(time=="night" && numofmin>100)
      {
      leftmin = numofmin-100;
      rate = leftmin*0.05;
      }

      if(time=="night" && numofmin<=100)
      {
      
      rate = 25;
      }
     }
     return rate;
}
      


