#include <iostream>
using namespace std;

string position(float h,float x,float y);
main()
{ 
    float h,x,y;
    string result;
    cout<<"enter value of h";
    cin>>h;

    cout<<"enter value of x";
    cin>>x;

    cout<<"enter value of y";
    cin>>y;

    result = position(h,x,y);
    cout<<"position of pt is:"<<result<<endl;
}

string position(float h,float x,float y)
{
    string posision;
 

    if((x==0 || x==3*h) && (y==0 || y==h))
       {
         posision="OnBorder";
       }

   else if(( x==h || x==2*h) && (y==0 || y==h || y==2*h || y==3*h || y==4*h))
       {
         posision="OnBorder";
       }

    else if (x>0 && x<3*h && y<h && y>0)
        {
         posision="inside";
        }

    else if ((x>h && x<2*h) && y<4*h && y>0)
        {
         posision="inside";
        }

    else
    {
       posision="Outside";
    }  
    
     return posision;

}
