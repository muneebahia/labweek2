#include <iostream>
using namespace std;

void discount(string day, int tpamount);
main()
{
 while(true)
 {
 string day;
 int tpamount;
 cout<<"enter day";
 cin>> day ;
 cout<<"enter payable ammount";
 cin>>tpamount;
 
 discount(day,tpamount);
 }

}

void discount(string day, int tpamount)
{
 int lessendamount,amountad;
 lessendamount=(tpamount*10)/100;
 
 amountad=tpamount-lessendamount;
 
  if(day=="sunday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;

  }
   if(day!="sunday")
   {
    cout<<"discount is not available";
  
   }
 
}
