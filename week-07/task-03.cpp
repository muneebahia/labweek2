#include<iostream>
using namespace std;
void print(int num)
{
    int n1=0;
    int n2=1;
    int num;
    for(int x=1 ; x<=num; x=x+1)
    {
        int next = n1+n2;
        cout<<next;
        n1=n2;
        n2=next;

    }
}

main()
{
int num;
cout<<"enter num";
cin>>num;
 print(int num);

 }
