#include <iostream>
using namespace std;

main()
{
  float hours,workers,days,wastedays, workingdays,workinghours,tworkinghours;

 cout<<"enter needed hours:";
 cin>>hours;
 cout<<"enter number of workers:";
 cin>>workers;
 cout<<"enter days:";
 cin>>days;

 wastedays =(days*10)/100;
 workingdays=days-wastedays;
 workinghours=workingdays*10;
 tworkinghours=workinghours*workers;
 
 if(hours<=tworkinghours)
 {
  float lefthours;
  lefthours=tworkinghours-hours;
  cout<<"yes!"<<lefthours<<"hours left"<<endl;
}

 if(hours>tworkinghours)
 {
  float additionalhours;
  additionalhours=hours-tworkinghours;
  cout<<"not enough time!"<<additionalhours<<"hours required"<<endl;
}

}



