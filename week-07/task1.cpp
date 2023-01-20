#include<iostream>
using namespace std;
void table(int num);
main()
{
    int num;
    cout<<"enter num: ";
    cin>>num;

table(int num);
}


void table(int num)
{
    int num;
    for(int count=1; count<=10; count =count+1)
    {
     cout<<num<<"*<<count<<"="<<num<<endl;
    }

}