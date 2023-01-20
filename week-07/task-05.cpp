#include<iostream>
using namespace std;

void patients(int digit);
main()
{
    int digit;
    cout<<"enter num of inputs:";
    cin>>digit;

    patients(digit);

}

void patients(int digit)
{  
    int doctors=7;
    
    int untreated_patients=0;
    int treated_patients=0;

    for(int i=1;i<=digit;i++)
    {     
         int num_patients;
        cout<<"enter num of patients in one day:";
        cin>>num_patients;

        if(num_patients<=doctors)
        {
         treated_patients=treated_patients+num_patients;
        }

        if(i%3==0 && num_patients>doctors)
        {
           doctors=doctors+1;

        }
        
        if(num_patients>doctors)
        {
          treated_patients=treated_patients+doctors;
          untreated_patients=untreated_patients+(num_patients-doctors);
        }
    }
        cout<<"untreated patients are:"<<untreated_patients<<endl;
        cout<<"treated patients are:"<<treated_patients<<endl;
   
    
}
