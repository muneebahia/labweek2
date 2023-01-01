#include <iostream>
using namespace std;
void product();
void add();
main()
{
 while(true)
 {
   add();
   product();
 }
}

  void add()
 {
  int num1,num2,sum;
  cout<<"first num";
  cin>>num1;
  cout<<"second num";
  cin>>num2;
  sum=num1+num2;
  cout<<"sum is:"<<sum<<endl;
 }

 void product()
{
  int num3,num4,product;
  cout<<"3rd num:";
  cin>>num3;
  cout<<"4rth num is:";
  cin>>num4;
  product=num3*num4;
  cout<<"product is:"<<product<<endl;
}
  



