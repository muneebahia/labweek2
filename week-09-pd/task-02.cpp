#include<iostream>
using namespace std;

main()
{
    

string movie[5] = {"gladiator","starwars","teminator","takinglives","tombrider"};
int price[5] = {500,500,500,500,500};

string moviename;
cout<<"enter the name of the movie:";
cin>>moviename;
int discount;
int final_price;
int foundidx;
for(int idx=0; idx<5;idx++)
{
    if(moviename==movie[idx])
    {
         foundidx=idx;
    }
    if(foundidx%2==0)
    {
         discount=(price[idx]*10)/100;
         final_price=price[idx]-discount;
        
    }
    else{
         discount=(price[idx]*5)/100;
         final_price=price[idx]-discount;
        

    }
}
 cout<<final_price;
}