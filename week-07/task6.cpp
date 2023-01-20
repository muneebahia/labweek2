#include<iostream>
using namespace std;
int calculateGCD(int num1, int num2);
float calculateLCM(int num1, int num2,int result);

main()
{
    int num1,num2,result,result1,HCF;
    cout<<"enter num1: ";
    cin>>num1;
    cout<<"enter num2: ";
    cin>>num2;
    result=calculateGCD(num1,num2);
    cout<<result<<endl;
    result1=calculateLCM(num1,num2,result);
    cout<<result1<<endl;

}

int calculateGCD(int num1, int num2)
{  
    int HCF;
    for(int x =1; x<=num1;x++)
    {
        if(num1%x==0 && num2%x==0)
        {
                 HCF=x;
        }
    }
    return HCF;
}
float calculateLCM(int num1, int num2,int result)
{
    int LCM;
    LCM=(num1*num2)/result;
    return LCM;
}
