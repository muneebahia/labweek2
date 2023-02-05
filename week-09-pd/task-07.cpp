#include <iostream>
using namespace std;

main()
{
    int count=0;
    string name1,name2;
         cout << "enter word1: ";
        cin >> name1;
        cout<<"enter word2: ";
        cin>>name2;

        for(int i=0;name1[i]!='\0';i++)
        {
            for(int j=0;name2[j]!='\0';j++)
            {
                if(name1[i]==name2[j])
                {
                    name2[j]='#';
                    count=count+1;
                    break;
                }
            }

        }
cout<<count<<endl;

}
    



