#include<iostream>
using namespace std;

main()
{ 
    bool isfound=false;
    int size;
    cout<<"enter the size of the arry:";
    cin>>size;
    int num;
    cout<<"enter the num:";
    cin>>num;


    int numbers[size];
    for(int idx=0; idx<size; idx++)
    {
    cout<<"enter num1: ";
    cin>> numbers[idx];
    }

     for(int idx=0; idx<size; idx++)
    {

    if(numbers[idx]==num)
    {
        isfound=true;
        break;
    }

    }
    
    if(isfound==true)
    {
        cout<<"num is found";
    }

    else
    {
       cout<<"num not found";
    }

}