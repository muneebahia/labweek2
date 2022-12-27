#include <iostream>
using namespace std;
main(){
string name;
int adult,child,noadulttickt,nochildtickt,percentage,totalammount,afterdonnation,donation;
cout<<"enter movie name:";
cin>>name;
cout<<"name"<<name;
cout<<"enter aduil tickt price";
cin>>adult;
cout<<"enter child ticket price:";
cin>>child;
cout<<"no of adult tickts sold:";
cin>>noadulttickt;
cout<<"no of child tickt sold:";
cin>>nochildtickt;
cout<<"enter per to donate:";
cin>>percentage;
totalammount=(adult*noadultticket)+(child*nochildticket);
cout<<"total earned price"<<totalammount;
donnation=totalammount*percentage;
cout<<"amount donnated is:"<<donnation;
afterdonnation=totalammount-donnation;
cout<<"ammount after donnation"<<afterdonnation;
}