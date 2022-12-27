#include <iostream>
using namespace std;
main(){
int days,sioneday,monthlysalary,yearlysalary;
float salaryafterbonus,salaryaftertax,usdinpkp,dailysalary;
cout<<"enter working days";
cin>>days;
cout<<"enter salary in one day:";
cin>>sioneday;
cout<<"usd in pkps:";
cin>>usdinpkp;
monthlysalary=days*sioneday;
cout<<"salary in one month is:"<<monthlysalary;
yearlysalary=monthlysalary*12;
cout<<"salary in one year is:"<<yearlysalary;
salaryafterbonus=yearlysalary+(monthlysalary*2.5);
cout<<"salary after bonus is:"<<salaryafterbonus;
salaryaftertax=salaryafterbonus*0.25;
cout<<""<<salaryaftertax;
usdinpkp=salaryaftertax*226;
cout<<"in pakistani rs:"<<usdinpkp;
dailysalary=usdinpkp/365;
cout<<"salary in one day is:"<<dailysalary;

}