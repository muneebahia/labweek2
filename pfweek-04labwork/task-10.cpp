#include<iostream>
using namespace std;

void pakistan(string name,int dollars);
void ireland(string name,int dollars);
void india(string name,int dollars);
void england(string name,int dollars);
void canada(string name,int dollars);

main()
{
  string name;
  int dollars;
  cout<<"enter name:";
  cin>>name;
  cout<<"enter dollars:";
  cin>>dollars;

  pakistan(name,dollars);
  ireland(name,dollars);
  india(name,dollars);
  england(name,dollars);
  canada(name,dollars);
 }

 
void pakistan(string name,int dollars)
{
  int less,amountad;
  less=(dollars*5)/100;
  amountad=dollars-less;
  cout<<"lessened ammount is:"<<endl;
  cout<<"amount after discount is:"<<endl;
}

void ireland(string name,int dollars)
{
  int less,amountad;
  less=(dollars*10)/100;
  amountad=dollars-less;
  cout<<"lessened ammount is:"<<endl;
  cout<<"amount after discount is:"<<endl;
}
void india(string name,int dollars)
{
  int less,amountad;
  less=(dollars*20)/100;
  amountad=dollars-less;
  cout<<"lessened ammount is:"<<endl;
  cout<<"amount after discount is:"<<endl;
}
void england(string name,int dollars)
  
{
  int less,amountad;
  less=(dollars*30)/100;
  amountad=dollars-less;
  cout<<"lessened ammount is:"<<endl;
  cout<<"amount after discount is:"<<endl;
}
void canada(string name,int dollars)
  
{
  int less,amountad;
  less=(dollars*45)/100;
  amountad=dollars-less;
  cout<<"lessened ammount is:"<<endl;
  cout<<"amount after discount is:"<<endl;
}

