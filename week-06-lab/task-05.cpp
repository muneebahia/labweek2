#include<iostream>
using namespace std;

float totalincome(string type,int rows,int columns);

main()
{

 string type;
 int rows,columns;
 float totalprice;
 cout<<"enter type";
 cin>>type;

 cout<<"enter rows";
 cin>>rows;

 cout<<"enter columns";
 cin>>columns;

 totalprice=totalincome(type,rows,columns);
 cout<<"total price is:"<<totalprice<<endl;


}


float totalincome(string type,int rows,int columns)
{

 float price;

 if(type=="premium")
 {
  price=rows*columns*12;
 }

 if(type=="normal")
 {
  price=rows*columns*7.5;
 }

 if(type=="discount")
 {
  price=rows*columns*5;
 }

 return price;

}



 
 