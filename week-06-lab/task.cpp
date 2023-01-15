#include<iostream>
using namespace std;

void leftmin(float startinghour,float startingmin,float arrivalhour,float arrivalmin);
void requiredmin(float startinghour,float startingmin,float arrivalhour,float arrivalmin);
string print(float startinghour,float startingmin,float arrivalhour,float arrivalmin);

main()
{
    int startinghour;
    int startingmin;
    int arrivalhour;
    int  arrivalmin;
    string result;

cout<<"enter starting hour";
cin>>startinghour;

cout<<"enter starting min";
cin>>startingmin;

cout<<"enter arrival hour";
cin>>arrivalhour;

cout<<"enter arrival min";
cin>>arrivalmin;

result=print(startinghour,startingmin,arrivalhour,arrivalmin);
cout<<"result is:"<<result<<endl;

    
if(arrivalhour<=startinghour)
{
leftmin(startinghour,startingmin,arrivalhour,arrivalmin);
}

if(arrivalhour>=startinghour)
{
 requiredmin(startinghour,startingmin,arrivalhour,arrivalmin);
 
}


}

string print(float startinghour,float startingmin,float arrivalhour,float arrivalmin)
{
    string printed;
    if(arrivalhour==startinghour-1 && arrivalmin>=startingmin+30 )
    {
        printed = "On Time";
    }
    if(arrivalhour==startinghour && arrivalmin==startingmin)
    {
        printed = "On Time";
    }


    if(arrivalhour==startinghour && arrivalmin>=startingmin+1)
    {
        printed = "late";
    }

    if(arrivalhour>=startinghour+1 )
    {
        if( arrivalmin<=startingmin-1)
    {
         printed = "late";
    }
       if(arrivalmin>=startingmin)
    {
         printed = "late";
    }
    }

    if(arrivalhour==startinghour-1 && (arrivalmin>=startingmin && arrivalmin<=startingmin+29))
    {
         printed = "early";
    }

    if(arrivalhour<startinghour-1)
     {
        if(arrivalmin>=startingmin)
        {
            printed = "early";
        }

        if(arrivalmin<=startingmin-1)
        {
            printed = "early";
        }

     }


    return printed;
}

void leftmin(float startinghour,float startingmin,float arrivalhour,float arrivalmin)
{   
    float hour;
    float min; 
    float printed;
    if(arrivalhour==startinghour-1)
    {
        if(startingmin==0 )
        {
        printed = 60-arrivalmin;
        cout<<printed<<"min before the start."<<endl;   
        }


        if(startingmin>=1)
        {
         printed = (60+startingmin)-arrivalmin; 
         cout<<printed<<"min before the start."<<endl;

        }
    }

     else if(startinghour>arrivalhour+1)
    {
        if(startingmin==0 && arrivalmin>=01)
        {
            min = 60-arrivalmin;
            hour = (startinghour-arrivalhour)-1;
            cout<<hour<<":"<<min<<"before the start:"<<endl;
        }
        if(startingmin==arrivalmin || startingmin>arrivalmin)
        {
            min = startingmin-arrivalmin;
            hour = startinghour-arrivalhour;
            cout<<hour<<":"<<min<<"before the start:"<<endl;

        }
        if(startingmin>=1 && arrivalmin==0)
        {
            min = startingmin+arrivalmin;
            hour = startinghour-arrivalhour;
            cout<<hour<<":"<<min<<"before the start:"<<endl;

        }
    
    }
}


void requiredmin(float startinghour,float startingmin,float arrivalhour,float arrivalmin)
{
    float hour;
    float min;
    float printed;
     if(arrivalhour==startinghour+1)
    {
        
        if(startingmin>=1)
        {
         printed =60-(startingmin-arrivalmin);
         cout<<printed<<"min after the start."<<endl;   

        }
        if(startingmin==0 && arrivalmin>=1)
        {
            min = startingmin+arrivalmin;
            hour = arrivalhour-startinghour;
            cout<<hour<<":"<<min<< "after the start."<<endl;   

        }
    
        if(startingmin==arrivalmin)
        {
            min==startingmin-arrivalmin;
            hour==arrivalhour-startinghour;
             cout<<hour<<":"<<min<< "after the start."<<endl;   

        }
    }

    
    else if(arrivalhour==startinghour )
        {
            if(startingmin==0 && arrivalmin>=1)
            {
            printed = arrivalmin;  
            cout<<printed<<"min after the start."<<endl;   
            }

            if(arrivalmin>startingmin)
            {
            printed = arrivalmin-startingmin;  
            cout<<printed<<"min after the start."<<endl;   
            }


        }
        
     else if(startinghour<arrivalhour+1)
     {
        if(startingmin==arrivalmin || arrivalmin>startingmin)
        {
            min = arrivalmin-startingmin;
            hour = arrivalhour-startinghour;
            cout<<hour<<":"<<min<< "after the start."<<endl;   

        }

       if(startingmin==0 && arrivalmin>=1)
            {
            min = arrivalmin+startingmin;  
            hour= arrivalhour-startinghour;
            cout<<hour<<":"<<min<< "after the start."<<endl;   

            }

       if(startingmin>=1 && arrivalmin==0)
        {
            min = 60-startingmin;
            hour = (arrivalhour-startinghour)-1;
            cout<<hour<<":"<<min<<"after the start:"<<endl;

        }
     }
}