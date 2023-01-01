#include<iostream>
using namespace std;

void condition(string input);

main()
{
 while(true)
{
 string input;
 
 cout<<"enter any condition";
 cin>>input;
 condition(input);
}
}

  void condition(string input)
   {
     
    if (input== "true")
     {
      cout<<"false";
     }
     if (input=="false")
     {
       cout<<"true";
     }
    }