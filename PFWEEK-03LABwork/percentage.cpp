#include <iostream>
using namespace std;
main(){
string name;
float sub1,sub2,sub3,sub4,sub5,percentage,obtainedmarks;
cout<<"name:";
cin>>name;
cout<<"sub1 marks:";
cin>>sub1;
cout<<"sub2 marks:";
cin>>sub2;
cout<<"sub3 marks:";
cin>>sub3;
cout<<"sub4 marks:";
cin>>sub4;
cout<<"sub5 marks:";
cin>>sub5;
obtainedmarks = sub1+sub2+sub3+sub4+sub5;
cout<<"obtained marks are:"<<obtainedmarks;
cout<<""<<endl;
percentage=obtainedmarks*100/500;
cout<<"my percentage is:"<<percentage;
}