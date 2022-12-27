#include <iostream>
using namespace std;
main() {
int mb,kb=1024,bytes=1024,bits=8;

cout<<"enter megabytes";
cin>>mb;

bits = mb*kb*bytes*8;
cout<<" bits are:"<<bits;
}
