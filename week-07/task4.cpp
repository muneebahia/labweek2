#include<iostream>
using namespace std;
int frequencychecker(int num,int digit);

main()
{
    int num,digit,result;
    cout<<"enter num:";
    cin>>num;
    cout<<"enter digit:";
    cin>>digit;
    
    result = frequencychecker( num,digit);
    cout<<"result is:"<<result<<endl;

}
int frequencychecker(int num,int digit)
{
    int num1;
    int count = 0;
    
    
    while(num>0)
    {
       num1 = num%10;
       num = num/10;
       if(num1==digit)  
       {
        count = count+1;
        
       }

    }
    return count;
}
