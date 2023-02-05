#include<iostream>
using namespace std;

main()
{ 
    int arry1[2];

    for(int idx=0; idx<2; idx++)
    {
    cout<<"enter num : ";
    cin>> arry1[idx];
    }

    int size_arry2;
    cout<<"enter the size of the arry2:";
    cin>>size_arry2;

    int arry3[size_arry2+2];
    int arry2[size_arry2];

    for(int idx=0; idx<size_arry2; idx++)
    {
    cout<<"enter num : ";
    cin>> arry2[idx];
    }

    arry3[0]=arry1[0];
    arry3[size_arry2+1]=arry1[1];

    for(int idx=0; idx<size_arry2;idx++)
    {
        arry3[idx+1]=arry2[idx];
    }


    for(int idx=0; idx<size_arry2+2;idx++)
    {
      cout<< arry3[idx]<<" ";
    }

}


