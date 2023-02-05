#include<iostream>
using namespace std;

main()
{ 
    
string name;
cout<<"enter string";
getline(cin ,name);


for(int idx=0;name[idx]!='\0';idx++)
{
    if(name[idx]=='a' || name[idx]=='e'|| name[idx]=='i' || name[idx]=='o' || name[idx]=='u')
    {
       continue;
    }
    else
    {
      cout<<name[idx];
      
    }



}

}