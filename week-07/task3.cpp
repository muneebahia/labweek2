#include<iostream>
using namespace std;
int totaldigits(int num);
main()
{
    int num,count;
    cout<<"enter num";
    cin>>num;
    result=totaldigits(num);
{
    cout<<result;
}

int totaldigits(int num)
{
    int count=0;
    while(num>0)
    {
        count=count+1;
        num = num/10;
    }
    return count;
}
}