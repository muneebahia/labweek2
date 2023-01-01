#include<iostream>
using namespace std;
void sum(int num1,int num2);
void sub(int num1,int num2);
void mul(int num1,int num2);
void divid(int num1,int num2);

main()
{
 int num1,num2,symbol;
 cout<<"enter num1:";
 cin>>num1;
 cout<<"enter num2";
 cin>>num2;
 cout<<"enter any symbol(-,+,*,/)";
 cin>>symbol;

  if(symbol=='+')
    {
      sum(num1,num2);
    }
  if(symbol=='-')
    {
      sub(num1,num2);
    }
  if(symbol=='*')
    {
      mul(num1,num2);
    }
  if(symbol=='/')
    {
      divid(num1,num2);
    }

}
    void sum(int num1,int num2)
   {
     int add;
     add=num1+num2;
     cout<<"sum is:"<<add<<endl;
   }

     void sub(int num1,int num2)
   {
     int minus;
     minus=num1-num2;
     cout<<"sub is:"<<minus<<endl;
   }
     void mul(int num1, int num2)
   {
     int multiply;
     multiply=num1*num2;
     cout<<"mul is:"<<multiply<<endl;
   }
     void divid(int num1,int num2)
   {
     int div;
     div=num1/num2;
     cout<<"div is:"<<div<<endl;
   }

