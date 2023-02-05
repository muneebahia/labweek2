#include<iostream>
using namespace std;

main()
{ 
    float sum;
    int numbers[4];

    float num;
    cout<<"enter num you want to check:";
    cin>>num;
    for(int idx=0; idx<4; idx++)
    {
    cout<<"enter num: ";
    cin>> numbers[idx];

    }

   sum=numbers[0]*0.25+numbers[1]*0.10+numbers[2]*0.05+numbers[3]*0.01;
   if(num<sum)
   {
    cout<<"true";
   }
    else if(num>sum)
   {
    cout<<"false";
   }

}

