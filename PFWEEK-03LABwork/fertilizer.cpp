
#include <iostream>
using namespace std;
main(){
float size,coast,area,perpound,persquarefeet;
cout<<"enter bag size in pounds:";
cin>>size;
cout<<"enter cost of the bag:";
cin>>coast;
cout<<"area covered by each bag in square feet:";
cin>>area;
perpound=coast/size;
cout<<"coast of fertilizer per pound"<<perpound;
persquarefeet=coast/area;
cout<<"coast of fertilizer per square feet:"<<persquarefeet;
}