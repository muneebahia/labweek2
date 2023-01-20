#include<iostream>
using namespace std;
int triangle(int triangle_number);

main()
{
    int triangle_number,result;
    cout<<"enter the number of triangle=";
    cin>> triangle_number;

    result=triangle(triangle_number);
    cout<<result<<"dots";

}

int triangle(int triangle_number)
{

     int count=0;
    
    for(int num=1;num<=triangle_number;num++)
    {
        count=count+num;
    }
      return count;

}

