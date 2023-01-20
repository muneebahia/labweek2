#include<iostream>
using namespace std;

float calculateMoney(float entered_age, float machine_price, float toy_price);

main()
{
    float entered_age;
    float machine_price;
    float toy_price,result;
    cout<<"enter entered_age=";
    cin>>entered_age;
    cout<<"enter machine_price=";
    cin>> machine_price;
    cout<<"enter toy_price=";
    cin>>toy_price;

    result=calculateMoney(entered_age,machine_price,toy_price);
     
     if(result - machine_price > 0)
     {
        cout<<"yes!"<<result-machine_price<<"rupees are left.";
     }

     if(result - machine_price < 0)
     {
        cout<<"no!"<<machine_price-result<<"rupees are required.";
     }

}

float calculateMoney(float entered_age, float machine_price, float toy_price)
{     
    float odd_money,even_money,total_money;
    float oddage_num =0;
    float evenage_num =0;
    float totalodd_money =0;
    float totaleven_money =0;
    for(int age = 1; age<=entered_age;age++)
    {
        if(age%2!=0)
        {
          oddage_num = oddage_num+1;
         
        }

         if(age%2==0)
        {
          evenage_num = evenage_num+1;
          even_money =  (evenage_num* 10)-1;
          totaleven_money = totaleven_money+ even_money;
        }

    }
     odd_money =  oddage_num* toy_price;
     totalodd_money = totalodd_money+ odd_money;
    total_money = totalodd_money+totaleven_money;
    return total_money;
}
