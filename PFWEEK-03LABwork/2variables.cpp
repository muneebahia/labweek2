#include <iostream>
using namespace std;
main(){
int input,remainder,sum=0;
cout<<"x=";
cin>>input;

remainder=input%10;
sum=sum+remainder;

input=input/10;
remainder=input%10;
sum=sum+remainder;

input=input/10;
remainder=input%10;
sum=sum+remainder;

input=input/10;
remainder=input%10;
sum=sum+remainder;

input=input/10;
remainder=input%10;
sum=sum+remainder;

cout<<"sum is:"<<sum;
}