#include <iostream>
using namespace std;

float taxcalculator(char type,float price);

main()
{
 
 float price;
 char type;
 float result;
 cout <<"enter vehcile type:";
 cin>>type;
 cout <<"enter vehcile price:";
 cin>>price;

 result=taxcalculator(type,price);
 cout<<"final result is:"<<result<<endl;

 }

  float taxcalculator(char type,float price)
  {
   float taxammount;
   float finalprice;

   if(type== 'M')
   {
    taxammount=(price*6)/100;
    finalprice=price+taxammount;
  
    return finalprice;

   }


   if(type== 'E')
   {
    taxammount=(price*8)/100;
    finalprice=price+taxammount;
    cout<<""<<finalprice<<endl;
    return finalprice;

    
   }


   if(type== 'S')
   {
    taxammount=(price*10)/100;
    finalprice=price+taxammount;
    cout<<""<<finalprice<<endl;
    return finalprice;

   }


   if(type== 'V')
   {
    taxammount=(price*12)/100;
    finalprice=price+taxammount; 
    cout<<""<<finalprice<<endl;
    return finalprice;

   }

   if(type== 'T')
   {
    taxammount=(price*15)/100;
    finalprice=price+taxammount;
    cout<<""<<finalprice<<endl;
    return finalprice;

   }

    

}



