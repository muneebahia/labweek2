#include <iostream>
using namespace std;
main(){
float vp,frp,earning,inrupees;
int kgsofv,kgsoffruit;
cout<<"enter vegitable price per kgs";
cin>>vp;

cout<<"enter fruit price per kgs";
cin>>frp;

cout<<"enter total kgs of vegitable";
cin>>kgsofv;

cout<<"enter total kgs of fruits";
cin>>kgsoffruit;

earning=(vp*kgsofv)+(frp*kgsoffruit);
cout<<"total earning in coins is:"<<earning;
cout<<""<<endl;
inrupees=earning/1.94;
cout<<"total earnig in rupees:"<<inrupees;
}


