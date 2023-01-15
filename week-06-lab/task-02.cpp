#include <iostream>
using namespace std;

float discount(string day, string month, float ammount);

main()
{
  float ammount,result;
  string month,day;
  cout<<"enter month";
  cin>>month;

  cout<<"enter day";
  cin>>day;

  cout<<"enter ammount";
  cin>>ammount;

  result=discount( day,  month, ammount);
  cout<<""<<result<<endl;

}


float discount(string day, string month, float ammount)
{
  float ammountad;
     if(day=="sunday" && month=="october")
     {
      ammountad = ammount- (ammount*10)/100;
     }

     else if(day=="sunday" && month=="march")
      {
        ammountad = ammount- (ammount*10)/100;
      }

     else if(day=="sunday" && month=="august")
      {
        ammountad = ammount- (ammount*10)/100;
      }

     else
     {
       cout<<"no discount"<<endl;
     }

     return ammountad;
 }

  


