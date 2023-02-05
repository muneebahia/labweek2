#include<iostream>
using namespace std;

main()
{ 
    
string name;
cout<<"enter string";
getline(cin ,name);
int count=0;
int idx=0;
while(name[idx]!='\0')
{
count++;
}

    
     for(int idx=count-1;idx>=0;idx--)
     {
         cout<<name[idx]; 

     }

}