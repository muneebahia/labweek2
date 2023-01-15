#include <iostream>
#include <cmath>
using namespace std;

float play(string year,int holidays,int travellweekends);

main()
{

 string year;
 float holidays;
 float travellweekends,playingdays;

 cout<<"enter year type:";
 cin>>year;

 cout<<"enter holidays:";
 cin>>holidays;

 cout<<"enter weekends under travelling:";
 cin>>travellweekends;

 playingdays = play(year,holidays,travellweekends);
 cout<<"the total playing days in year are:"<<playingdays<<endl;


}


 
float play(string year,int holidays,int travellweekends)
{
   float leftweekends,notworking,weekendsinsofia,holidays1,playingdays,leapcontribution;
    

    if(year=="normal")
    {
      leftweekends = 48-travellweekends;
      notworking = (leftweekends*3)/4;
      weekendsinsofia = floor(notworking);
      holidays1 = (holidays*2)/3;
      playingdays = weekendsinsofia+holidays1+travellweekends;
     
    }

    if(year=="leap")
    {
      
     leftweekends = 48-travellweekends;
      notworking = (leftweekends*3)/4;
      weekendsinsofia = floor(notworking);
      holidays1 = (holidays*2)/3;
      playingdays = weekendsinsofia+holidays1+travellweekends;

     float leapcontribution =  (playingdays*15)/100;
     playingdays = playingdays+leapcontribution;
     playingdays = ceil(playingdays);
    }
     return playingdays;

}
