#include <iostream>
using namespace std;

int isgreater(int num1,int num2);
int isminimum(int num1,int num2);
main()
{ int result;
  int num1,num2;
  cout<<"enter num1";
  cin>>num1;
  cout<<"enter num2";
  cin>>num2;
  result=isgreater(num1,num2);
  cout<<"greater number is:"<<result<<endl;
  result=isminimum(num1,num2);
  cout<<"smaller number is:"<<result<<endl;


}
 
  int isgreater(int num1,int num2)
  {
   if(num1>num2)
    {
      return num1;
     }
   if(num2>num1)
    {
      return num2;
     }
    return 0;
 }

 int isminimum(int num1,int num2)
  {
   if(num1<num2)
    {
      return num1;
     }
   if(num2<num1)
    {
      return num2;
     }
    return 0;
 }

