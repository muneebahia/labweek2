#include<iostream>
using namespace std;
void printhalf(int rows);
main()
{
    int rows;
    cout<<"enter num of rows=";
    cin>>rows;
    printhalf( rows);
}


void printhalf(int rows)
{
    for(int i=0;i<rows;i++)
    {
        int space;
        space = rows - i;
        for(int j=space;j>0;j--)
        {
            cout<<"*";
        } 

        

            space=space-1;
            
            cout<<endl;
    
        
    }    
}