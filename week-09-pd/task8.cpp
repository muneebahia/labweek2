#include<iostream>
using namespace std;

main()
{ 
    
string name;
cout<<"enter string";
getline(cin ,name);
int count;
for(int idx=0; name[idx]!='\0'; idx++)
{
    count++;
}

if(count%2==0)
{
cout<<"even";
}

if(count%2!=0)
{
cout<<"odd";
}

}