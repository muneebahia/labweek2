#include<iostream>
using namespace std;

float studio(string month,float numofstays);
float apartment(string month,float numofstays);

main()
{
    string month;
    float numofstays;

    cout<<"enter month";
    cin>>month;
    cout<<"enter number of stays";
    cin>>numofstays;

    studio(month,numofstays);
    cout<<"studio fee:"<<studio(month,numofstays)<<endl;
    apartment(month,numofstays);
    cout<<"apartment:"<<apartment(month,numofstays)<<endl;

}

float studio(string month,float numofstays)
{      
      float totalprice,ammountleft;
      if(month=="october" || month=="may")
       {

        if(numofstays>7  && numofstays<=14)
         {
          totalprice = numofstays*50;
          ammountleft = totalprice-(totalprice*0.05);
         }

         if(numofstays<=7)
         {
          totalprice = numofstays*50;
          ammountleft = totalprice;
         }
         if( numofstays>14)
         {
          totalprice = numofstays*50;
          ammountleft = totalprice-(totalprice*0.3);

         }
       }

      if(month=="august" || month=="july")
        {
         totalprice = numofstays*76;
         ammountleft = totalprice;
        }

        if(month=="june" || month=="september")  
     {
       if(numofstays>14)
        {  
          totalprice = numofstays*75.20;
         ammountleft = totalprice-(totalprice*0.2);
        }
       
       if(numofstays<=14)
       {
         totalprice = numofstays*75.20;
         ammountleft = totalprice;
       }  
     }    
        return ammountleft;
}
float apartment(string month,float numofstays)
{   
     float totalprice,ammountleft;
    
        if(month=="may" || month=="october")
        {
          if(numofstays>14)
          {
             totalprice = numofstays*65;
             ammountleft = totalprice-(totalprice*0.1);
          }

        if(numofstays<=14)
         {
             totalprice = numofstays*65;
             ammountleft = totalprice;
         }
        }

        if(month=="june" || month=="september")
        {
          if(numofstays>14)
          {
             totalprice = numofstays*68.70;
             ammountleft = totalprice-(totalprice*0.1);
          }

       if(numofstays<=14)
         {
             totalprice = numofstays*68.70;
             ammountleft = totalprice;
         }
        }


        if(month=="july" || month=="august")
        {
          if(numofstays>14)
          {
             totalprice = numofstays*77;
             ammountleft = totalprice-(totalprice*0.1);
          }

        if(numofstays<=14)
          {
             totalprice = numofstays*77;
             ammountleft = totalprice;
          }
        }
           return ammountleft;
}