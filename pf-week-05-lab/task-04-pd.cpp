#include<iostream>
using namespace std;

int condition(int num);
main()
{
 while(true)
 {
   int num,result;
   cout<<"enter num";
   cin>>num;

   result=condition(num);
 }
}

 int condition(int num)
 {
  int rem,rem1,remain,remain1,remainder,remainder1,remainder2,remainder2a,rem2,sum,sum1,sum2;
  rem=num%10;
  rem1=num/10;
  remain=rem1%10;
  remain1=rem1/10;
  remainder=remain1%10;
  remainder1=remain1/10;
  remainder2=remainder1%10;
  remainder2a=remainder1/10;
  rem2=remainder2a%10;
  sum=rem+remain+remainder+remainder2+rem2;
  
 if(sum%2 == 0)
 {
  cout<<"evenish"<<endl;
 }

 if(sum%2 ==1)
 {
  cout<<"oddish"<<endl;
 }

  return sum2;

}




