#include <iostream>
using namespace std;

bool possibility(int num1,int num2,int num3);

main()
{

  int num1;
  int num2;
  int num3;
  
  cout<<"enter num1:";
  cin>>num1;

  cout<<"enter num2:";
  cin>>num2;

  cout<<"enter num3:";
  cin>>num3;

  bool result=possibility(num1,num2,num3);
  if(1)
  {
    cout<<"yes"<<endl;
  }

  if(0)
  {
    cout<<"no"<<endl;
  }


}


  bool possibility(int num1,int num2,int num3)
  {
   
   if(num1==num2 && num1==num3)
   {
     return true;
   }


   if(num1!=num2 && num1!=num3)
   {
     return false;
   }


   
   
}


