#include<iostream>
#include<cmath>
using namespace std;


main()
{
 float num1,num2,result,result1;
 cout<<"enter num1";
 cin>>num1;

 cout<<"enter num2";
 cin>>num2;

 result= max(num1,num2);
 cout<<"maximum num is:"<<result<<endl;

 result= min(num1,num2);
 cout<<"minimum num is:"<<result<<endl;
 
 result1=ceil(12.6);
 cout<<"value is:"<<result1<<endl;

 result1=floor(12.6);
 cout<<"round value is:"<<result1<<endl;

 result1=pow(2,8);
 cout<<"answer is:"<<result1<<endl;

 


}