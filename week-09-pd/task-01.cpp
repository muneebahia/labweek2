#include<iostream>
using namespace std;

main()
{
    

string fruit[4] = {"peach", "apple", "guava", "watermelon"};
int price[4] = {60, 70, 40, 30};

string fruitename;
cout<<"enter the name of the fruite:";
cin>>fruitename;

int kgs;
cout<<"enter kgs:";
cin>>kgs;

for(int idx=0; idx<4; idx++)
{
    int final_price=kgs*price[idx];
    if(fruitename==fruit[idx])
    {
      cout<<fruitename<<" "<<final_price;
    }

}

}






