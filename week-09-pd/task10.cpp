#include<iostream>
using namespace std;

main()
{ 

 string name;
 cout<<"enter string";
getline(cin ,name);

char letter;
cout<<"enter letter";
cin>>letter;



int count=name.length();
if(name[count-1]==letter)
{
    cout<<"same";
}
else
{
    cout<<"not same";
}
}

