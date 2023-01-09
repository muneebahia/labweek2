#include<iostream>

using namespace std;
int result(int num);
main()
{
while(true)
 {
  int num,finalresult;
  cout<<"entre num:";
  cin>>num;
  
  finalresult=result(num);
}
 
}

 
  int result(int num)
{
 int remain,rem,rem1,remain1,remainder;
 rem=num%10;
 rem1=num/10;
 remain=rem1%10;
 remain1=rem1/10;
 remainder=remain1%10;

 if(rem==remainder)
  {
    cout<<"true"<<endl;
  }
  if(rem!=remainder)
  {
   cout<<"false"<<endl;
   }
 return remainder;
}
