#include <iostream>
using namespace std;
void add(int num1,int num2);
void product(int num1,int num2);
void sub(int num1,int num2);
void divid(int num1, int num2);
main()
{
 while(true)
 {
  int num1,num2;
  char symbol; 

  cout<<"enter num1";
  cin>>num1;
  cout<<"enter num2";
  cin>>num2;
  cout<<"enter any operation(+,-,/,*)";
  cin>>symbol;
  
  if (symbol=='+')
  {
  add(num1,num2);
  }
  if(symbol=='*')
  {
  product(num1,num2);
  }
  if(symbol=='-')
  {
  sub(num1,num2);
  }
  if(symbol=='-')
  {
  divid(num1,num2);
  }
 }
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
  void divid(int num1, int num2)
{
  int div;
  div=num1/num2;
  cout<<"ans is:"<<div<<endl;
}
