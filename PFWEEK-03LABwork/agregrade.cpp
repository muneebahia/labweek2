#include <iostream>
using namespace std;
main() {
float matric,matricpercentage,inter,interpercentage,ecat,ecatpercentage,matricweight,interweight,ecatweight,agregrade;
cout<<"enter matric marks:";
cin>>matric;
matricpercentage = (matric/1100)*100;
cout<<"matric pecentage is:"<<matricpercentage;
cout<<""<<endl;
cout<<"enter inter marks:";
cin>>inter;
interpercentage = (inter/520)*100;
cout<<"inter percentage is:"<<interpercentage;
cout<<" "<<endl;
cout<<"enter ecat marks:";
cin>>ecat;
ecatpercentage = (ecat/400)*100;
cout<<"ecat percentage is:"<<ecatpercentage;
cout<<" "<<endl;
matricweight = (matricpercentage*10)/100;
cout<<"weight 1"<<matricweight;
cout<<" "<<endl;
interweight = (interpercentage*40)/100;
cout<<"weight 2"<<interweight;
cout<<" "<<endl;
ecatweight = (ecatpercentage*50)/100;
cout<<"weight 3"<<ecatweight;
cout<<" "<<endl;
agregrade = matricweight+interweight+ecatweight;
cout<<"agregrade is:"<<agregrade;
}




