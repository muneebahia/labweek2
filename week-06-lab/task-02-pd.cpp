#include<iostream>
using namespace std;

string grade(float chem,float socialsciences,float bio,float eng,float math);


main()
{
float chem,phy;
float socialsciences;
float bio;
float eng;
float math;
string name;

cout<<"enter name ";
cin>>name;

cout<<"enter chem marks";
cin>>chem;

cout<<"enter phy marks";
cin>>phy;

cout<<"enter socialsciences marks";
cin>>socialsciences;

cout<<"enter bio marks";
cin>>bio;

cout<<"enter eng marks";
cin>>eng;


string result = grade(chem,socialsciences,bio,eng,math);
cout<<"grade is:"<<result<<endl;

}
string grade(float chem,float socialsciences,float bio,float eng,float math)
{
    float obtained;
    string grading;
    float percent;
    obtained = chem+socialsciences+bio+eng+math;
    percent= (obtained/500)*100;
    cout<<"percent is"<<percent<<endl;

    if(percent<=100 && percent>90)
    {
        grading="A+";
    }

        if(percent<=90 && percent>80)
    {
        grading="A";
    }


    if(percent<=80 && percent>70)
    {
        grading="B+";
    }

    if(percent<=70 && percent>60)
    {
        grading="B";
    }

    if(percent<=60 && percent>50)
    {
        grading="C";
    }

        return grading;


}

