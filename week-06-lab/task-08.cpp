#include <iostream>
using namespace std;

float percentage(float budget,int numofpeople,string type);

main()
{

 float budget,result;
 int numofpeople;
 string type;

 cout<<"enter budget";
 cin>>budget;

 cout<<"enter type";
 cin>>type;

 cout<<"enter numofpeople";
 cin>>numofpeople;


  result=percentage(budget,numofpeople,type);

  if(result<budget)
  {
    float leftammount=budget-result;
    cout<<"yes! You have"<<leftammount<<"leva left.";
  }

  if(result>budget)
  {
    float requiredammount = result-budget;
    cout<<"no enough money! You need"<<requiredammount<<"leva.";
  }

}



  float percentage(float budget,int numofpeople,string type)

  {
   
   float budget1;
   float total;
   if(numofpeople>=1 && numofpeople<=4)
   {
     if(type=="normal")
     {

        budget1=(budget*75)/100;
        total=budget1+(249.99*numofpeople);
        
     }

     if(type=="VIP")
     {

        budget1=(budget*75)/100;
        total=budget1+(499.99*numofpeople);
        
     }

   }

   else if(numofpeople>=5 && numofpeople<=9)
   {

     if(type=="normal")
     {

        budget1=(budget*60)/100;
        total=budget1+(249.99*numofpeople);
     
        
     }


     if(type=="VIP")
     {

        budget1=(budget*60)/100;
        total=budget1+(499.99*numofpeople);
     
    
     }
   }



   else if(numofpeople>=10 && numofpeople<=24)
   {

     if(type=="normal")
     {

       budget1=(budget*50)/100;
       total=budget1+(249.99*numofpeople);
      
     }


     if(type=="VIP")
     {

        budget1=(budget*50)/100;
        total=budget1+(499.99*numofpeople);
     
     
      }

   }



   else if(numofpeople>=25 && numofpeople<=49)
   {

     if(type=="normal")
     {

        budget1=(budget*40)/100;
        total=budget1+(249.99*numofpeople);
     
     
     }


     if(type=="VIP")
     {

        budget1=(budget*40)/100;
        total=budget1+(499.99*numofpeople);
     
        
     }

   }



   else if(numofpeople>=50)
   {
    

     if(type=="normal")
     {

        budget1=(budget*25)/100;
        total=budget1+(249.99*numofpeople);
     
        
     }


     if(type=="VIP")
     {

        budget1=(budget*25)/100;
        total=budget1+(499.99*numofpeople);
     
       
     }
     
   }
     return total;
}





   


