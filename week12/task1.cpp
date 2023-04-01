#include <iostream>
using namespace std;
bool grid();
int cart[3][3] = {{1, 0, 0},
                  {0, 1, 0},
                  {0, 0, 1}};

main()
{
  bool result;
  result=grid();
  if(result==true)
  {
    cout<<"identity matrix "<<endl;
  }
  else{
    cout<<"Not!!!!!!!!!!!"<<endl;
  }

}
bool grid()
{
    int count = 0;
    bool flag = false;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (i = j && cart[i][j] != 1)
            {
                flag = false;
            }
   
            if (i != j && cart[i][j] == 1)
            {
                flag = false;
            }
        }
    }
    return flag;
}