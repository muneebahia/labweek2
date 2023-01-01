#include <iostream>
using namespace std;
void checkresult(int marks);
main()
{
 while(true)
 {
 int marks;
 cout<<"enter marks";
 cin>>marks;
 checkresult(marks);
 }

}

void checkresult(int marks)
{
 
  if(marks>50)
  
{  
  cout<<"pass"; 
}
  if(marks<50)
{
   cout<<"fail"; 

}
  if(marks==50)
{
    cout<<"you need to improve"; 
 
}  

}