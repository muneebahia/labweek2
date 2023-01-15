#include <iostream>
using namespace std;

string checkspeed(float speed);

main()
{
 float speed;
 cout<<"enter speed";
 cin>>speed;

 result=checkspeed(speed);
 cout<<"result is:"<<result<<endl;
}

string checkspeed(float speed)
{
 string velocity;

 if(speed<=10)
 {
  velocity="slow";
 }

  if(speed>=11 && speed<=50)
 {
   velocity="average";
 }

  if(speed>=51 && speed<=150)
 {
   velocity="fast";
 }

  if(speed>=150 && speed<=1000)
 {
   velocity="ultra-fast";
 }

 return velocity;

}
