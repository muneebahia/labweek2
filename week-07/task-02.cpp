#include<iostream>
using namespace std;
void print(int num);

main()
{
int num;
cout<<"enter num";
cin>>num;
 print(num);

 }

void print(int num)
{
    int n1=0;
    int n2=1;
    int next;
    cout<<n1<<","<<n2;
    for(int x=1 ; x<=num-2; x=x+1)
    {
         next = n1+n2;
        cout<<","<<next;
        n1=n2;
        n2=next;

    }
}
