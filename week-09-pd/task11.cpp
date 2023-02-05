#include<iostream>
using namespace std;

main()
{ 

 string name;
 cout<<"enter string";
getline(cin ,name);

char letter;
cout<<"enter letter you want to search in arry: ";
cin>>letter;
int count=0;
int idx=0;
 while(name[idx]!='\0')
 {
    if(name[idx]==letter)
    {
        count++;
    }
    idx++;
 }

 cout<<count;
}
