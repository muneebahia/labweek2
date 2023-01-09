#include<iostream>
using namespace std;


float centiM(float length,float width,float bridth);
float kiloM(float length,float width,float bridth);
float milliM(float length,float width,float bridth);
float Meter(float length,float width,float bridth);


main()
{

  int length,width,bridth,unit,centimeter,millimeter,kilometer,meter,volume;
  cout<<"enter length:";
  cin>>length;
  cout<<"enter width:";
  cin>>width; 
  cout<<"enter bridth:";
  cin>>bridth;
  cout<<"enter unit :";
  cin>>unit;
 
  if(unit==centimeter)
  {
   volume=centiM(length,width,bridth);

  }


  if(unit==kilometer)
  {
  volume=kiloM(length,width,bridth);
   
  }


  if(unit==millimeter)
  {
   volume=milliM(length,width,bridth);
   
  }


  if(unit==meter)
  {
   volume=Meter(length,width,bridth);
   
  }

   cout <<volume;

}

 float centiM(float length,float width,float bridth)

  { 
   float volume = (((length*width*bridth)/3)*1000000);
   //cout<<"volume is:"<<volume<<endl;
   return volume;
  }

  float kiloM(float length,float width,float bridth)

  {
   float volume = (((length*width*bridth)/3)*0.000000001);
   //cout<<"volume is:"<<volume<<endl;
    return volume;
  }

   float milliM(float length,float width,float bridth)
  {
   float volume = (((length*width*bridth)/3)*1000000000);
   //cout<<"volume is:"<<volume<<endl;
   return volume;
  }

   float Meter(float length,float width,float bridth)
  {
   float volume = (length*width*bridth)/3;
  //cout<<"volume is:"<<volume<<endl;
   return volume;
  }
