#include <iostream>
using namespace std;

float prise(string type,string day,float ammount);

main()
{
    string type;
    string day;
    float ammount,result;

    cout<<"enter day name";
    cin>>day;

    cout<<"enter fruit type";
    cin>>type;

    cout<<"enter fruit ammount";
    cin>>ammount;

   result = prise(type,day,ammount);
   cout<<"final price is:"<<result<<endl;

}

float prise(string type,string day,float ammount)
{   
    float pric;
      if(day=="monday" || day=="tuesday" || day=="wednesday" || day=="thursday" || day=="friday")
    {
        if(type=="banana")
        {
        pric=ammount*2.50;
        }

        if(type=="apple")
        {
        pric=ammount*1.20;
        }

       if(type=="orange")
        {
        pric=ammount*0.85;
        } 

       if(type=="grapefruite")
        {
        pric=ammount*1.45;
        }

       if( type=="kiwi")
        {
        pric=ammount*2.70;
        }

       if(type=="pineapple")
        {
        pric=ammount*5.50;
        }

       if(type=="grapes")
       {
        pric=ammount*3.85;
       }

      
    }

    if(day=="sunday" || day=="saturday")
    {
        if(type=="banana")
        {
        pric=ammount*2.70;
        }

        if(type=="apple")
       {
        pric=ammount*1.25;
       }

        if(type=="orange")
       {
        pric=ammount*0.90;
       }
        if(type=="grapefruit")
       {
        pric=ammount*1.60;
       }

        if(type=="kiwi")
       {
        pric=ammount*3.00;
       }

        if(type=="pineapple")
       {
        pric=ammount*5.60;
       }

        if(type=="grapes")
       {
        pric=ammount*4.20;
       }

    }
      return pric;
       
}
