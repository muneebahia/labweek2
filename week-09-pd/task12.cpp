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
    if(name[idx]=='a' || name[idx]=='e'|| name[idx]=='i' || name[idx]=='o' || name[idx]=='u')
    {
     count++;
    }

      idx++;


}
   cout<<count;

}