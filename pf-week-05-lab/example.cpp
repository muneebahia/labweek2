#include <iostream>
using namespace std;

int add (int num1,int num2);
float divide (float num1,float num2);

main()
{
 int num1,num2;
 float result;
 cout<<"enter num1";
 cin>>num1;
 cout<<"enter num2";
 cin>>num2;
 
 result=add(num1,num2);
 cout<<"result is:"<<result<<endl;

 result=divide(num1,num2);
 cout<<"result is:"<<result<<endl;
}

  int add (int num1,int num2)
  {
 
  float result=num1+num2;
  return result;
  }

  float divide (float num1,float num2)
  {
 
    float result=num1/num2;
    return result;
  }
