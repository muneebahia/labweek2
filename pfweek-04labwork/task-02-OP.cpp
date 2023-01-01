#include <iostream>
using namespace std;
void add(int num1,int num2);
void product(int num3,int num4);
void sub(int num1,int num2);
main()
{
  int num1,num2;
  cout<<"enter num1";
  cin>>num1;
  cout<<"enter num2";
  cin>>num2;
  add(num1,num2);
  product(num1,num2);
  sub(num1,num2);
}

void add(int num1,int num2)
{
  int sum;
  sum=num1+num2;
  cout<<"sum is:"<<sum<<endl;
} 
void product(int num1,int num2)
{
  int mul;
  mul=num1*num2;
  cout<<"product is:"<<mul<<endl;
}
 void sub(int num1,int num2)
{
  int subtraction;
  subtraction=num1-num2;
  cout<<"subtraction is:"<<subtraction<<endl; 
} 
