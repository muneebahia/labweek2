#include<iostream>
using namespace std;

main()
{
int flag=false;
string name;
cout<<"enter the name :";
getline(cin,name);
int length=name.length();
if(length%2==0)
{
   flag=true;
}
else
{
    flag=false;
}
cout<<flag;
}