#include<iostream>
using namespace std;

float heightis(float angle,float base);
main()
{
 float angle,base,ans,height;
 cout<<"enter angle";
 cin>>angle;
 cout<<"enter base length";
 cin>>base;
 height=heightis(angle,base);
 cout<<"height is"<<height<<endl;
}


float heightis(float angle,float base)
{

 float angle,base,ans,height,radian,radians;
 radian=57.2958;
 radians= angle/radians;
 ans=tan(radians);
 height=ans*base;
 
 return height;
 }
