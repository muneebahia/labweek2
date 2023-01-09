#include<iostream>
#include<cmath>
using namespace std;

float positivequa(float entera,float enterb,float enterc);
float negativequa(float entera,float enterb,float enterc);

main()
{
  float a,b,c,result3;
  cout<<"enter value of a";
  cin>>a;
  cout<<"enter value of b";
  cin>>b;
  cout<<"enter value of c";
  cin>>c;

  result3=positivequa(a,b,c);
  cout<<"positive ans is"<<result3<<endl;

  result3=negativequa(a,b,c);
  cout<<"negative ans is"<<result3<<endl;


}

 float positivequa(float entera,float enterb,float enterc)
 {
   float a,b,c,beesquare,fourac,result1,result2,sub1,twoa,finalr;
   
   beesquare=pow(b,2);
   fourac=4*a*c;
   sub1=beesquare-fourac;
   result1=sqrt(sub1);
   result2= -b-result1;
   twoa=2*a;
   finalr=result2/twoa;

   return finalr;
} 

 float negativequa(float entera,float enterb,float enterc)
 {
   float a,b,c,beesquare,fourac,result1,result2,sub1,twoa,finalr;
   
   beesquare=pow(b,2);
   fourac=4*a*c;
   sub1=beesquare-fourac;
   result1=sqrt(sub1);
   result2= -b+result1;
   twoa=2*a;
   finalr=result2/twoa;

   return finalr;
}