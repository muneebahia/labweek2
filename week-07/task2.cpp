#include<iostream>
using namespace std;

void example(int rows);
main()
{
    int rows;
    cout<<"enter num of rows";
    cin>>rows;
     example(rows);

}
void example(int rows)
{
    int n=rows;
    for(int i=1;i<=rows;i++)
    {
        for(int j=1;j<=n ;j++)
        {
            cout<<"*";
        }
         n=n-1;
        cout<<endl;
    }
    
}

