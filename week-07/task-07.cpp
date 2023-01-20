#include<iostream>
using namespace std;
void printPercentage( float digit);

main()
{
    float digit,num;
    cout<<"enter digit:";
    cin>>digit;
    printPercentage(digit);

}

void printPercentage(float digit)
{
float p1=0;
float p2=0;
float p3=0;
float p4=0;
float p5=0;
float num;
float percentage_p1;
float percentage_p2;
float percentage_p3;
float percentage_p4;
float percentage_p5;
for(int count=1;count<=digit;count++)
{
float num;
cout<<"enter num:";
cin>>num;
if(num<200)
{
    p1=p1+1;

}
if(num>=200 && num<=399)
{
    p2=p2+1;
}
if(num>=400 && num<=599)
{
    p3=p3+1;
}
if(num>=600 && num<=799)
{
    p4=p4+1;
}

if(num>=800 && num<=1000)
{
    p5=p5+1;
}

}

 percentage_p1 = (p1/digit)*100;
cout<<"1_percentage is:"<<percentage_p1<<endl;

 percentage_p2 = (p2/digit)*100;
cout<<"2_percentage is:"<<percentage_p2<<endl;

percentage_p3 = (p3/digit)*100;
cout<<"3_percentage is:"<<percentage_p3<<endl;

percentage_p4 = (p4/digit)*100;
cout<<"4_percentage is:"<<percentage_p4<<endl;

percentage_p5 = (p5/digit)*100;
cout<<"5_percentage is:"<<percentage_p5<<endl;


}
