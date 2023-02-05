#include<iostream>
using namespace std;

main()
{ 
    
string name;
cout<<"enter string";
getline(cin ,name);

int idx=0;
while(name[idx]!='\0')
{
cout<<"character="<<name[idx]<<" "<<"at index="<<idx++<<endl;
}


}