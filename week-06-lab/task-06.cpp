#include <iostream>
using namespace std;

float lessprice(string time,float kilometer);

main()
{
  string time;
  float kilometer,result;

  cout<<"enter time:";
  cin>>time;

  cout<<"enter kilometer:";
  cin>>kilometer;

  result=lessprice(time,kilometer);
  cout<<"result is:"<<result<<endl;
}


float lessprice(string time,float kilometer)
{

 float payable;

   if(kilometer<20 )
   {
     if(time=="day")
     {
       payable=0.7+(kilometer*0.79);
     }
  
     if(time=="night")
     {
       payable=0.7+(kilometer*0.90);
     }
   }

 if(kilometer>=20 && kilometer<100 )

   {

       if(time=="day")
     {
       payable=kilometer*0.09;
     }
  
     if(time=="night")
     {
       payable=kilometer*0.09;
     }

   }

 if(kilometer>=100 && kilometer<=5000 )
  
  {

        if(time=="day" || time=="night")
     {
       payable=kilometer*0.06;
     }
  
  }
    return payable;

  
}









