#include<iostream>
using namespace std;

void average(int digit);
main()
{
    int digit;
    cout<<"enter num of digits:";
    cin>>digit;
    average(digit);


}

void average(int digit)
{   float sum=0;
    float minibus=0;
    float truck=0;
    float train=0;
    float average_value;
    float percentage_p1;
    float percentage_p2;
    float percentage_p3;



    for(int count=1;count<=digit;count++)
    {
        int tonn;
        cout<<"enter num of tonn:";
        cin>>tonn;

        sum = sum+tonn;
        if(tonn<=3)
        {
           minibus =minibus+tonn; 

        }
        if(tonn>3 && tonn<=11)
        {
           truck=truck+tonn; 

        }

         if(tonn>11)
        {
           train=train+tonn; 

        }



    }

 percentage_p1 = (minibus/sum)*100;
 cout<<"1_percentage is:"<<percentage_p1<<endl;

 percentage_p2 = (truck/sum)*100;
 cout<<"2_percentage is:"<<percentage_p2<<endl;

 percentage_p3 = (train/sum)*100;
 cout<<"3_percentage is:"<<percentage_p3<<endl;

average_value=(minibus*200+truck*175+train*120)/sum;
cout<<"average value is:"<<average_value<<endl;

}

