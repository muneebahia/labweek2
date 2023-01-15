#include<iostream>
using namespace std;

string checktitle(int age,char gender);

main()
{
  int age;
  char gender;
  string title;
  cout<<"enter age";
  cin>>age;
  cout<<"enter gender";
  cin>>gender;

 title=checktitle(age,gender);
 cout<<"the title is:"<<title<<endl;

}


string checktitle(int age,char gender)
{

  string title;
  if(age>=16 && gender=='M')
  {
    title="mr.";
  }

  if(age<16 && gender=='M')
  {
    title="master";
  }

  if(age>=16 && gender=='F')
  {
    title="ms.";
  }

  if(age<16 && gender=='F')
  {
    title="miss";
  }

  return title;
}








  

