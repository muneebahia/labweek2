#include<iostream>
using namespace std;

string sign(string month,int date);

main()
{
    string month,result;
    int date;
    cout<<"enter date";
    cin>>date;

    cout<<"enter month";
    cin>>month;
    result = sign(month,date);
    cout<<"sign is:"<<result<<endl;
}

string sign(string month,int date)
{
    string astrologicalsign;
    if((date>=21 && month=="march") || (date<=19 && month=="april"))
    {
         astrologicalsign = "aries";
    }

        if((date>=20 && month=="april") || (date<=20 && month=="may"))
    {
         astrologicalsign = "taurus";
    }

        if((date>=21 && month=="may") || (date<=20 && month=="june"))
    {
         astrologicalsign = "gemini";
    }

        if((date>=21 && month=="june") || (date<=22 && month=="july"))
    {
         astrologicalsign = "cancer";
    }

    if((date>=23 && month=="july") || (date<=22 && month=="august"))
    {
         astrologicalsign = "leo";
    }

        if((date>=23 && month=="august") || (date<=22 && month=="september"))
    {
         astrologicalsign = "virgo";
    }

    if((date>=23 && month=="september") || (date<=22 && month=="october"))
    {
         astrologicalsign = "libra";
    }

        if((date>=23 && month=="october") || (date<=21 && month=="november"))
    {
         astrologicalsign = "scorpio";
    }

        if((date>=22 && month=="november") || (date<=21 && month=="december"))
    {
         astrologicalsign = "sagittarius";
    }

        if((date>=22 && month=="december") || (date<=19 && month=="january"))
    {
         astrologicalsign = "capricorn";
    }

        if((date>=20 && month=="january") || (date<=18 && month=="feb"))
    {
         astrologicalsign = "aquarius";
    }

        if((date>=19 && month=="feb") || (date<=20 && month=="march"))
    {
         astrologicalsign = "pisces";
    }
     return  astrologicalsign;

}











