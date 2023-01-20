#include<iostream>
using namespace std;
int sumdigits(int num);
main()
{
    int num,count,result;
    cout<<"enter num";
    cin>>num;
    result=sumdigits(num);
    cout<<result;
}

int sumdigits(int num)
{
    int count=0;
    while(num>0)
    {
        int num1;
         
         num1 = num%10;
         count=count+num1;
         num = num/10;

    }
    return count;
}
