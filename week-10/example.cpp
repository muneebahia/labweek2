#include <iostream>
using namespace std;
int checkcount(string check, char letter);

main()
{
    int size;
    cout << "enter the size of arry: ";
    cin >> size;

    string word[size];
    for (int i = 0; i < size; i++)
    {
        cout << "enter the word";
        cin >> word[i];
    }
    string check;

    char letter;
    cout << "enter the letter you want to compare:";
    cin >> letter;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        check = word[i];
        sum = sum + checkcount(check, letter);
    }
    cout << sum;
}

int checkcount(string check, char letter)
{
    int count = 0;
    for (int i = 0; check[i] != '\0'; i++)
    {
        if (check[i] == letter)
        {
            count++;
        }
    }

    return count;
}
