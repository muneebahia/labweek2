#include<iostream>
using namespace std;

main()
{
    int no_of_resistors;
    cout<<"enter the num of resistors you want to arrange in series:";
    cin>>no_of_resistors;


   
    int total_resitance=0;
    int resistance[ no_of_resistors];
    for(int idx=0; idx< no_of_resistors; idx++)
    {
        cout<<"enter the resistance:";
        cin>>resistance[idx];
        total_resitance = total_resitance+resistance[idx];

    }
        cout<<" total resitance is:"<<total_resitance;

}


