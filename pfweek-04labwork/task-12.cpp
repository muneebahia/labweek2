#include<iostream>
using namespace std;

void totalAD(int red,int white,int tulips);
void orignalprice(int red,int white,int tulips);

main()
{
 int red,white,tulips;
 
 cout<<"enter no of red roses:";
 cin>>red;
 cout<<"enter no of white roses:";
 cin>>white;
 cout<<"enter no of tulips roses:";
 cin>>tulips;
 
  totalAD(red,white,tulips);
  orignalprice(red,white,tulips);
}
  void orignalprice(int red,int white,int tulips)
  {
   int output;
   output=(red*2)+(white*4.0)+(tulips*2.50);

  }
   void totalAD(int red,int white,int tulips)
  {
   int output,discount,amountad;
   output=(red*2)+(white*4.0)+(tulips*2.50);
   discount=(output*20)/100;
   amountad=output-discount;

   if (output>200)
   {
     cout<<"amount after discount is:"<<amountad<<endl;
    }

   if (output<200)
   {
     cout<<"discount is not available";
    }
   }
   

  
