#include <iostream>
using namespace std;

string activity(string temp,string humidity);

main()
{
string temp;
string humidity;

cout<<"enter temp";
cin>>temp;

cout<<"enter humidity";
cin>>humidity;

 string acti=activity(temp,humidity);
cout<<"the activity is:"<<acti<<endl;
}


string activity(string temp,string humidity)
{
    string activitye;
   if(temp=="warm" && humidity=="dry")
   {
    activitye="play tennis";
    
   }

   if(temp=="warm" && humidity=="humid")
   {
     activitye="swim";
   }
   if(temp=="cool" && humidity=="humid")
   {
     activitye="watchTV";
   }
  if(temp=="cool" && humidity=="dry")
   {
     activitye="playbascketball";
   }
    return activitye;
}









