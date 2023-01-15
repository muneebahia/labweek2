#include <iostream>
using namespace std;

float checkcost(string city,string product,int quantity);

main()
{
  string city;
  string product;
  int quantity;
  float totalprice;


  cout<<"enter city:";
  cin>>city;

  cout<<"enter product::";
  cin>>product;


  cout<<"enter quantity:";
  cin>>quantity;

  totalprice = checkcost(city,product,quantity);
  cout<<"total price is:"<<totalprice<<endl;



}

  float checkcost(string city,string product,int quantity)
  {

    float price;
    if(city=="sofia")
    { 
      if(product=="coffee")
      {
        price=0.50*quantity;
      }


      if(product=="watre")
      {
        price=0.80*quantity;
      }


      if(product=="beer")
      {
        price=1.20*quantity;
      }


      if(product=="sweets")
      {
        price=1.45*quantity;
      }


      if(product=="peanuts")
      {
        price=1.60*quantity;
      }

    }

    if(city=="plovdiv")
    { 
      if(product=="coffee")
      {
        price=0.40*quantity;
      }


      if(product=="watre")
      {
        price=0.70*quantity;
      }


      if(product=="beer")
      {
        price=1.15*quantity;
      }


      if(product=="sweets")
      {
        price=1.30*quantity;
      }


      if(product=="peanuts")
      {
        price=1.50*quantity;
      }

    }

    if(city=="varna")
    { 
      if(product=="coffee")
      {
        price=0.45*quantity;
      }


      if(product=="watre")
      {
        price=0.70*quantity;
      }


      if(product=="beer")
      {
        price=1.10*quantity;
      }


      if(product=="sweets")
      {
        price=1.35*quantity;
      }


      if(product=="peanuts")
      {
        price=1.55*quantity;
      }

    }
    return price;
  }