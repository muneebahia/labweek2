#include<iostream>
using namespace std;


main()
{

  int price;
  string brand;

  cout<<"enter num:";
  cin>>price;
  cout<<"enter brand:";
  cin>>brand;


  if(price<=1500 && brand== "outfitters")
  {
    cout<<"buy shirt"<<endl;
  }

  else
  {
    cout<<"not buy shirt !"<<endl;
  }
}



