#include <iostream>
using namespace std;

void sunday(string day, int tpamount);

void otherdays(string day,int tpamount);
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
 
 sunday(day,tpamount);

 otherdays(day,tpamount);

 }

}

void sunday(string day, int tpamount)
{
 int lessendamount,amountad;
 lessendamount=(tpamount*10)/100;
 
 amountad=tpamount-lessendamount;
 
  if(day=="sunday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;
  }

}
 void otherdays(string day,int tpamount)
 {
   int lessendamount,amountad;
   lessendamount=(tpamount*5)/100;
 
   amountad=tpamount-lessendamount;

     if(day=="monday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;

  }
    if(day=="tuesday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;

  }
    if(day=="wednesday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;

  }
    if(day=="thursday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;

  }
    if(day=="friday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;

  }
    if(day=="saturday")
  {
    cout<<"lessendamount is:"<<lessendamount<<endl;
    cout<<"amount after discount is:"<<amountad<<endl;

  }
}
