#include<iostream>
using namespace std;

float calculateMoney(float entered_year, float inherited_money);

main()
{
    float entered_year,result;
    float inherited_money2;
    cout<<"enter entered_year=";
    cin>>entered_year;
    cout<<"enter inherited money=";
    cin>> inherited_money2;
    result=calculateMoney( entered_year, inherited_money2);

      if(result > 0)
     {
        cout<<"yes! he will live free life and will have  "<< result<<"  dollars left.";
     }

     if(result < 0)
     {
        cout<<"no! he will not have enough money and  "<< result<<"  dollars are required.";
     }


}

float calculateMoney(float entered_year, float inherited_money2)
{     
    
    float age = 17;
    for(int year = 1800; year<=entered_year;year++)
    {
        age=age+1;

         if(year%2==0)
        {
         inherited_money2 =inherited_money2 - 12000.00;
        }
        if(year%2!=0)
        {
         inherited_money2 =inherited_money2 -(12000.00+ 50.00 *(age));
        }
    }


    return inherited_money2;
     
    
}