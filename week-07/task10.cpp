#include<iostream>
using namespace std;
void sequence(int digit);
main()
{
    int digit;
    cout<<"enter digit:";
    cin>>digit;
    sequence( digit);

}

void sequence(int digit)
{    int number;
    for(int num=1 ;num<=digit;num++)
    {
        if(num%4==0)
        {
          number= num*10;
            cout<<number<<","; 
            continue;
        }
        cout<<num<<","; 
        
         
    } 
}

