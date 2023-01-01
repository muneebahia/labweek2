#include<iostream>
using namespace std;
void equal(int num1,int num2);

main()
{ 
while(true)
{
 system("cls");
 int num1,num2;
 cout<<"enter num1:";
 cin>>num1;
 cout<<"enter num2:";
 cin>>num2;

 equal(num1,num2);
}

}
void equal(int num1,int num2)
{ 
  if(num1==num2)
   {
     cout<<"true";
    }

  if(num1!=num2)
   {
     cout<<"false";
    }
 }

