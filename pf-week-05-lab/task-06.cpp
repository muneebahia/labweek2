#include <iostream>
using namespace std;

void res(int num1);
void result(int num1);


main()
{
 int num1;
 cout<<"enter num:";
 cin>>num1;


  if(num1>=0 && num1<=10)
  { 

  res(num1);
  }


  if(num1>=20 && num1<=99)
  { 

  result(num1);
  }
}

  void res(int num1)
  {

     if(num1==1)
     {
      cout<<"one";
     }


     if(num1==2)
     {
      cout<<"two";
     }


     if(num1==3)
     {
      cout<<"three";
     }


     if(num1==4)
     {
      cout<<"four";
     }


     if(num1==5)
     {
      cout<<"five";
     }


     if(num1==6)
     {
      cout<<"six";
     }


     if(num1==7)
     {
      cout<<"seven";
     }


     if(num1==8)
     {
      cout<<"eight";
     }


     if(num1==9)
     {
      cout<<"nine";
     }


     if(num1==10)
     {
      cout<<"ten";
     }

}

  void result(int num1)
 {

   if(num1>=20 && num1<=29)
   {
    int num2;
    cout<<"twenty";
    num2=num1%10;

    num1=num2;
    res(num1);
   }  



  
   if(num1>=30 && num1<=39)
   { 
    int num2;
    cout<<"thirty";
    num2=num1%10;

    num1=num2;
    res(num1);
  }
  

   if(num1>=40 && num1<=49)
   {
    int num2;
    cout<<"fourty";
    num2=num1%10;

    num1=num2;
    res(num1);
  }
  


   if(num1>=50 && num1<=59)
   {
    int num2;
    cout<<"fifty";
    num2=num1%10;

    num1=num2;
    res(num1);
  }
  
  
   if(num1>=60 && num1<=69)
   {
    int num2;
    cout<<"sixty";
    num2=num1%10;

    num1=num2;
    res(num1);
   }
  


   if(num1>=70 && num1<=79)
   { 
    int num2;
    cout<<"seventy";
    num2=num1%10;

    num1=num2;
    res(num1);
   }
 


   if(num1>=80 && num1<=89)
   {
    int num2;
    cout<<"eighty";
    num2=num1%10;

    num1=num2;
    res(num1);
   }
  


   if(num1>=90 && num1<=99)
   {
    int num2;
    cout<<"ninty";
    num2=num1%10;

    num1=num2;
    res(num1);
   }
 }

