#include <iostream>
using namespace std;
main(){
float initialv,finalv,acceleration,time;
cout<<"enter initial velocity:";
cin>>initialv;
cout<<""<<endl;
cout<<"enter acceleration:";
cin>>acceleration;
cout<<""<<endl;
cout<<"enter time:";
cin>>time;
cout<<""<<endl;
cout<<"enter final velocity:";
cin>>finalv;
cout<<""<<endl;
finalv=initialv+(acceleration*time);
cout<<"final velocity is:"<<finalv;
}