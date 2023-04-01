#include <iostream>
#include <fstream>
using namespace std;

main()
{
    string name;
    //  float integer=12.7;
    //  int num=12;
    fstream file;
    file.open("example.txt", ios::out);
    //getline(file, name);
    file << name << endl;
    file.close();

    // file.open("example.txt", ios::in);
    // file >> integer;
    // file << integer << endl;
    // file.close();

    // file.open("example.txt", ios::in);
    // file >> num;
    // file << num << endl;
    // file.close();
}
