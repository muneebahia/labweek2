#include<iostream>
using namespace std;

main()
{
    int size;
    cout<<"enter the size of the arry:";
    cin>>size;


   float average;
    int sum=0;
    int num[size];
    for(int idx=0; idx<size; idx++)
    {
        cout<<"enter the num:";
        cin>>num[idx];
        sum=sum+num[idx];

    }
        cout<<"sum is:"<<sum<<endl;

         average=sum/size;
         cout<<"average is:"<<average;


}


