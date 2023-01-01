#include<iostream>
using namespace std;

void numtype(int number);
main()
{
 while(true)
{
 int number;
 cout<<"enter num";
 cin>>number;

 numtype(number);
}
}

void numtype(int number)
{
  if(number%2==0)
   {
    cout<<"num is even"<<endl;
   }

    if(number%2!=0)
   {
    cout<<"num is odd"<<endl;
   }
 
}
