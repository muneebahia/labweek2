#include<iostream>
using namespace std;

float isgreater(float num1,float num2,float num3);

main()

{
  float num1,num2,num3,result;
  cout<<"enter num1:";
  cin>>num1;

  cout<<"enter num2:";
  cin>>num2;

  cout<<"enter num3:";
  cin>>num3;


  result = isgreater(num1,num2,num3);
  cout<<"result is:"<<result<<endl;


}


float isgreater(float num1,float num2,float num3)

{
  float greatest;

  if(num1>num2 && num1>num3)
  {
   cout<<"greater num is:"<<num1<<endl;
    greatest = num1;
  }


  else if(num2>num1 && num2>num3)
  {
   cout<<"greater num is:"<<num2<<endl;
   greatest = num2;
  }


  else if(num3>num1 && num3>num2)
  {
   cout<<"greater num is:"<<num3<<endl;
    greatest = num3;
  }

  else
  {
    greatest=number1;
  }
    return greatest;
}
  
