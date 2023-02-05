#include<iostream>
using namespace std;

main()
{ 
    
    int size;
    cout<<"enter the size of the arry:";
    cin>>size;

    int num;
    cout<<"enter the num you want to multiply:";
    cin>>num;

    int multiply;
    int numbers[size];

    for(int idx=0; idx<size; idx++)
    {
    cout<<"enter number: ";
    cin>> numbers[idx];
    
    }
     for(int idx=size-1;idx>=0;idx--)
     {   
         multiply=numbers[idx]*num;
         cout<<multiply<<" "; 

     }

}