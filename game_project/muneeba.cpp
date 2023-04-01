#include <iostream>
#include <fstream>
#include <conio.h>
#include <windows.h>
using namespace std;
int feedback_count = 0;

string signin(string userName, string Password);
bool isvalidusername(string userName_);
bool isvalidpassword(string Password_);
void signup(string userName_, string Password_, string rolee_);
void storeinfile(string userName_, string Password_, string rolee_);
string takechoice();
void viewusers();
void readdatafromfile();
void admininterface();
void customer_interface();
void header();
void adminheader();
void userheader();
void listheader();
void deleteheader();
void updateheader();
void feedbackheader();
void cartheader();
void billheader();
void addheader() ;




void showlist();
void selected_items();
void add_medicine();
void store_newmedicineinfile(string new_medicine, int price_of_medicine, int stock_of_medicine);
string previous_record(string record, int field);
void delete_medicine();
void readmedicinefromfile();
void search_medicine();
void A_feedback();
void storeBills(int finalBill);
void deleteFromCart();
void viewCart();
void calculateBill();
void storeBills(int finalBill);
void loadBills();
void addItemToCart(); // function to validate numbers...
int validateFunction(string name);
bool validchoice(string choice);

// void read_feedback();
void C_feedback();
// void store_feedback(string feedback_name[feedback_count], string feedback_number[feedback_count], string feedback_comment[feedback_count])

// feedback arrays://////////////////////////
string feedback_name[100];
string feedback_number[100];
string feedback_comment[100];
string finalBills[1000];
int billCount = 0;

void update_stock();
string userName_;
string Password_;
string rolee_;

void updatefilefromarray();
int count_of_products = 0;
int usercount = 0;
int count = 0;
int medCount = 0;
int selected_medicine_price[1000];
string selected_medicine_name[1000];

string record;
int field;
// signup arrays/////////////////////////////////
string username[100];
string password[100];
string role[100];
string medicine[100];
string orderedMedicine[100];
int orderedPrice[100];
int quantity[100];
int Price[100];
int stock[100];
int bill, final_bill;
main()
{
    header();
    string choice;
    string choice1;

    readdatafromfile();
    readmedicinefromfile();
    loadBills();

    previous_record(record, field);

    bool decision, decision1;
    string result;

    choice = takechoice();
    while (choice != "0")
    {
        if (choice == "1")
        {
            system("cls");
            header();

            cout << "enter your username :";
            cin >> userName_;

            cout << "enter your password :";
            cin >> Password_;
            decision1 = isvalidpassword(Password_);
            cout << "enter your role :";
            cin >> rolee_;
            decision = isvalidusername(userName_);
            if (decision == true && decision1 == true)
            {
                signup(userName_, Password_, rolee_);
                storeinfile(userName_, Password_, rolee_);
                cout << "user created successfully" << endl;
                cout << "press any key to see the signin option" << endl;
            }
            else
            {
                cout << "user already exists or invalid password" << endl;
                cout << "press any key to go back" << endl;
            }
            getch();
        }
        else if (choice == "2")
        {
            system("cls");
            header();

            cout << "enter your username :";
            cin >> userName_;
            cout << "enter your password :";
            cin >> Password_;

            result = signin(userName_, Password_);
            if (result == "admin")
            {
                while (choice != "0")
                {
                    cin.ignore();
                    admininterface();
                    cout << "enter your choice:" << endl;
                    cin >> choice;
                    if (choice == "1")
                    {

                        showlist();
                    }
                    else if (choice == "2")
                    {

                        add_medicine();
                    }
                    else if (choice == "3")
                    {

                        delete_medicine();
                    }
                    else if (choice == "4")
                    {
                        update_stock();
                    }
                    else if (choice == "5")
                    {
                        search_medicine();
                    }
                    else if (choice == "6")
                    {
                        A_feedback();
                    }

                    else if (choice == "0")
                    {
                        break;
                    }
                }
            }

            else if (result == "customer")
            {
                while (choice1 != "0")

                {

                    cin.ignore();
                    customer_interface();
                    cout << "enter your choice:" << endl;
                    cin >> choice1;

                    if (choice1 == "1")
                    {

                        C_feedback();
                    }
                    else if (choice1 == "2")
                    {

                        showlist();
                    }
                    else if (choice1 == "3")
                    {
                        selected_items();
                    }
                    else if (choice1 == "4")
                    {
                        viewCart();
                    }
                    else if (choice1 == "5")
                    {
                        deleteFromCart();
                    }
                    else if (choice1 == "6")
                    {
                        addItemToCart();
                    }
                    else if (choice1 == "7")
                    {
                        calculateBill();
                    }
                    else if (choice1 == "0")
                    {
                        break;
                    }
                }
            }
        }

        else if (choice == "3")
        {
            system("cls");
            header();
            viewusers();
        }
        else
        {
            cout << "invalid choice!" << endl;
            cout << "press any key to signup again" << endl;
        }
        choice = takechoice();
    }
}

void signup(string userName_, string Password_, string rolee_)
{
    username[usercount] = userName_;

    password[usercount] = Password_;
    role[usercount] = rolee_;
    usercount++;
}
string signin(string userName_, string Password_)
{

    for (int i = 0; i < usercount; i++)
    {
        cout << role[i] << endl;
        if (userName_ == username[i] && Password_ == password[i])
        {
            bool valid = validateFunction(userName_);
            if (valid == true)
            {
                return role[i];
            }
            else
            {
                cout << "invalid input" << endl;
            }
        }
    }

    return "undefined";
    cout << "press any key to go back" << endl;
    getch();
}

bool isvalidusername(string userName_)
{
    bool flag = true;
    for (int i = 0; i < usercount; i++)
    {
        if (username[i] == userName_)
        {
            flag = false;
            break;
        }
    }
    return flag;
}
bool isvalidpassword(string Password)
{
    int flag = false;
    int length;
    length = Password.length();

    if (length == 8)
    {
        flag = true;
    }
    return flag;
}

void storeinfile(string userName_, string Password_, string rolee_)
{
    fstream file;
    file.open("users.txt", ios::app);

    file << userName_ << ","
         << Password_ << ","
         << rolee_ << endl;
    file.close();
}
string takechoice()
{
    system("cls");
    header();
    cout << endl;
    cout << endl;
    // mainheader();
    string choice;
    cout << "****************************************************************************************** " << endl;
    cout << "****************************                                                             * " << endl;
    cout << "*********************                                                                    * " << endl;
    cout << "**************                                                                           * " << endl;
    cout << "*********                                                                                * " << endl;
    cout << "*" << '\t' << '\t' << '\t' << '\t' << " Choose your choice :                                    * " << endl;
    cout << "*" << '\t' << '\t' << '\t' << '\t' << "1. for signup:                                           * " << endl;
    cout << "*" << '\t' << '\t' << '\t' << '\t' << "2. for signin:                                           * " << endl;
    cout << "*" << '\t' << '\t' << '\t' << '\t' << "3. view users                                            * " << endl;
    cout << "*" << '\t' << '\t' << '\t' << '\t' << "0. for exit                                              * " << endl;
    cout << "*" << '\t' << '\t' << '\t' << '\t' << "enter choice:                                            * " << endl;
    cout << "*                                                               ************************** " << endl;
    cout << "*                                                                          *************** " << endl;
    cout << "*                                                                                 ******** " << endl;
    cout << "****************************************************************************************** " << endl;
    cin >> choice;
    bool valid = validchoice(choice);
    if (valid == true)
    {
        return choice;
    }
    else
    {
        cout << "invalid" << endl;
        cout << "press any key to again enter the choice!!!" << endl;
    }
    getch();
}
void viewusers()
{
    cout << "username"
         << "\t\t"
         << "passwords"
         << "\t\t"
         << "role" << endl;

    for (int i = 0; i < usercount; i++)
    {
        cout << username[i] << "\t\t\t" << password[i] << "\t\t\t" << role[i] << endl;
    }
    cout << "press any key to go back" << endl;
    getch();
}

void readdatafromfile()
{
    string word;
    fstream file;
    file.open("users.txt", ios::in);
    while (!file.eof())
    {
        getline(file, word);
        username[usercount] = previous_record(word, 1);
        password[usercount] = previous_record(word, 2);
        // cout<<username[usercount]<< "  " << username[usercount].length() << endl;
        role[usercount] = previous_record(word, 3);
        usercount++;
    }
    // getch();
    file.close();
}
void admininterface()
{
    system("cls");
    adminheader();
    cout << endl;
    cout << endl;
    cout << endl;

    cout << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "0. logout" << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "1. Check list" << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "2. Add the medicine" << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "3. Delete medicine" << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "4. Update list " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "5. Can search specific medicine " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "6. feedback" << endl;
    cout << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "press any key to continue:" << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "press 0 to logout" << endl;
    getch();
}
void customer_interface()
{
    cout << endl;
    cout << endl;
    cout << endl;

    system("cls");
    userheader();
    cout << endl;
    cout << endl;
    cout << endl;

    cout << '\t' << '\t' << '\t' << '\t' << " 1.give feedback               " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << " 2.Show medicine list          " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << " 3.can select medicine         " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << " 4.view cart                   " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << " 5.delete medicine from cart   " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << " 6. Add new medicine in cart   " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << " 7.calculate bill              " << endl;
    cout << '\t' << '\t' << '\t' << '\t' << " 0.Logout                      " << endl;
    cout << endl;
    cout << '\t' << '\t' << '\t' << '\t' << "press any key to continue      " << endl;
    getch();
}

//////to show the medicine list to customer and admin/////////
void showlist()
{

    system("cls");
    listheader();
    cout << endl;
    cout << endl;
    cout << endl;

    cout << "index"
         << '\t' << '\t'
         << "medicine name"
         << '\t' << '\t'
         << "price"
         << '\t' << '\t'
         << "stock"
         << '\t' << '\t' << endl;

    for (int i = 0; i < count_of_products; i++)
    {

        cout << i + 1 << "\t\t" << medicine[i] << "\t\t" << Price[i] << "\t\t" << stock[i] << "\t\t" << endl;
    }
    cout << "press any key to continue:" << endl;
    getch();
}
//////to show the medicine list to customer and admin/////////

//////to the the medicinein the list by admin/////////
void add_medicine()
{
    int integer_price, integer_stock;

    string new_medicine;
    string price_of_medicine, stock_of_medicine;
    cout << "enter the name of the Medicin you want to add :";
    cin >> new_medicine;
    cout << "enter the price of that medicine :";
    cin >> price_of_medicine;

    cout << "enter the stock of that medicine :";
    cin >> stock_of_medicine;
    integer_price = atoi(price_of_medicine.c_str());
    integer_stock = atoi(stock_of_medicine.c_str());

    medicine[count_of_products] = new_medicine;
    Price[count_of_products] = integer_price;
    stock[count_of_products] = integer_stock;

    count_of_products++;
    store_newmedicineinfile(new_medicine, integer_price, integer_stock);
    //  updatefilefromarray();
    cout << "press any key to continue:";
    getch();
}
//////to the the medicinein the list by admin/////////

void store_newmedicineinfile(string new_medicine, int price_of_medicine, int stock_of_medicine)
{
    fstream file;
    file.open("add_product.txt", ios::app);
    file << new_medicine << "," << price_of_medicine << "," << stock_of_medicine << endl;
    file.close();
}
void readmedicinefromfile()
{
    string word;
    fstream file;

    file.open("add_product.txt", ios::in);
    while (!file.eof())
    {
        getline(file, word);
        if (word == "")
        {
            continue;
        }
        medicine[count_of_products] = previous_record(word, 1);
        Price[count_of_products] = atoi(previous_record(word, 2).c_str());
        stock[count_of_products] = atoi(previous_record(word, 3).c_str());
        count_of_products++;
    }
    file.close();
}
string previous_record(string record, int field)
{
    int commacount = 1;
    string item = "";
    for (int x = 0; x < record.length(); x++)
    {
        if (record[x] == ',')
        {
            commacount = commacount + 1;
        }
        else if (commacount == field)
        {
            item = item + record[x];
        }
    }
    return item;
}
void delete_medicine()
{
    system("cls");
    deleteheader();

    cout << endl;
    cout << endl;
    cout << endl;
    string deletedMedicine;
    cout << "enter the name of the product you want to delete :";
    cin >> deletedMedicine;
    for (int i = 0; i < count_of_products; i++)
    {

        if (deletedMedicine == medicine[i])
        {

            for (int j = i; j < count_of_products; j++)
            {
                medicine[j] = medicine[j + 1];
                Price[j] = Price[j + 1];
                stock[j] = stock[j + 1];
            }
            count_of_products--;
        }
        updatefilefromarray();
    }
    cout << "press any key to continue:";
    getch();
}

void updatefilefromarray()
{
    fstream file;
    file.open("add_product.txt", ios::out);
    for (int i = 0; i < count_of_products; i++)
    {
        file << medicine[i] << "," << Price[i] << "," << stock[i] << endl;
    }

    file.close();
}
void update_stock()
{
    system("cls");
    updateheader();
    cout << endl;
    cout << endl;
    cout << endl;

    string medicine_name;
    cout << "enter the name of the medicine whose price and stock you want to update:";
    cin >> medicine_name;

    int new_stock;
    cout << "enter the new stock of selected medicine:";
    cin >> new_stock;

    int new_price;
    cout << "enter the new price of medicine:";
    cin >> new_price;

    for (int i = 0; i < count_of_products; i++)
    {
        if (medicine_name == medicine[i])
        {
            stock[i] = new_stock;
            Price[i] = new_price;

            cout << medicine_name << " " << Price[i] << " " << stock[i] << endl;
        }
    }
    updatefilefromarray();
    cout << "press any key to continue:";
    getch();
}

void search_medicine()
{
    system("cls");
    header();
    string search_Medicine;
    cout << "enter the name of the Medicin you want to search :";
    cin >> search_Medicine;
    cout << "medicine name"
         << "\t\t"
         << "stock"
         << "\t\t"
         << "Price"
         << "\t\t" << endl;
    for (int i = 0; i < count_of_products; i++)
    {
        if (search_Medicine == medicine[i])
        {
            cout << medicine[i] << "\t\t" << Price[i] << "\t\t" << stock[i] << "\t\t" << endl;
        }
    }
    updatefilefromarray();

    cout << "press any key to continue:";
    getch();
}
void A_feedback()
{
    system("cls");
    feedbackheader();
    cout << endl;
    cout << endl;
    cout << endl;


    for (int i = 0; i < feedback_count; i++)
    {
        cout << i + 1 << ".";
        cout << "NAME: " << feedback_name[i] << endl;
        cout << "PHONE_NUMBER: " << feedback_number[i] << endl;
        cout << "" << endl;
        cout << "     " << feedback_comment[i] << endl;
        cout << " " << endl;
        // getch();
    }
    cout << endl;

    cout << "press any key to continue :";
    getch();
}

void C_feedback()
{
    system("cls");
    feedbackheader();
    cout<<endl;
    cout<<endl;
    cout<<endl;

    while (true)
    {
        int choice;
        cout << "enter your name: ";
        cin.ignore();
        getline(cin, feedback_name[feedback_count]);
        cout << "enter your phone_number: ";
        // cin.ignor();
        getline(cin, feedback_number[feedback_count]);
        cout << "enter your comment: ";
        // cin.ignor();
        getline(cin, feedback_comment[feedback_count]);
        feedback_count++;
        cout << "respond/comment added successfully!!!!!!";
        cout << endl;
        cout << "enter 1 to give another respond and press 0 to go back:";
        cin >> choice;
        if (choice == 1)
        {
            continue;
        }
        else
        {
            break;
        }
    }
}


void selected_items()
{
    system("cls");
    header();
    showlist();
    int choice = 1;

    int position_of_medicine;
    while (choice != 0)
    {
        cout << "enter index of medicines you want to buy:" << endl;
        cin >> choice;
        orderedMedicine[medCount] = medicine[choice - 1];
        orderedPrice[medCount] = Price[choice - 1];
        // selected_medicine_price[count]=quantity;
        if (choice <= count_of_products)
        {
            if (choice != 0)
            {
                cout << "enter quantity of medicine you want to buy:" << endl;
                cin >> quantity[medCount];
                medCount++;
            }
        }
        cout << "press 0 to go back:";
    }
}
void viewCart()
{

    cartheader();
    cout<<endl;
    cout<<endl;
    cout<<endl;
        cout << "index"
         << '\t' << '\t'
         << "medicine name"
         << '\t' << '\t'
         << "price"
         << '\t' << '\t'
         << "stock"
         << '\t' << '\t' << endl;

    for (int idx = 0; idx < medCount; idx++)
    {
        cout <<idx+1<<'\t' << '\t'<< orderedMedicine[idx] << '\t' << '\t' << orderedPrice[idx] << '\t' << '\t' << quantity[idx] << endl;
    }
    getch();
}
void totalBill()
{
    int bill;
    int finalBill;
    for (int idx = 0; idx < medCount; idx++)
    {
        bill = quantity[idx] * orderedPrice[idx];
        finalBill = finalBill + bill;
        storeBills(finalBill);
    }
    getch();
}
void storeBills(int finalBill)
{
    fstream file;
    file.open("bill.txt", ios::app);
    file << finalBill << endl;
    file.close();
}
void loadBills()
{
    fstream file;
    string word;
    file.open("bill.txt", ios::in);
    while (!file.eof())
    {
        getline(file, word);
        if (word == "")
            break;
        finalBills[billCount] = previous_record(word, 1);
        billCount = billCount + 1;
    }
    file.close();
}
void addItemToCart()
{
    showlist();
addheader();
cout<<endl;
cout<<endl;
cout<<endl;

    int choice;
    cout << "Enter the number of medicine you want to add:" << endl;
    cin >> choice;
    cout << "Enter quantity:";
    cin >> quantity[medCount];
    orderedMedicine[medCount] = medicine[choice - 1];
    orderedPrice[medCount] = Price[choice - 1];

    cout << "enter any key" << endl;
    getch();
}
void deleteFromCart()
{
    system("cls");
    deleteheader();
    for (int idx = 0; idx < medCount; idx++)
    {
        cout << idx + 1 << '\t' << '\t' << orderedMedicine[idx] << '\t' << '\t' << orderedPrice[idx] << '\t' << '\t' << quantity[idx] << endl;
    }
    int num;
    cout << "Enter the number of medicine you want to delete:";
    cin >> num;
    if (num <= medCount)
    {
        medCount = medCount - 1;
        for (int idx = num - 1; idx < medCount; idx++)
        {
            orderedMedicine[idx] = orderedMedicine[idx + 1];
            orderedPrice[idx] = orderedPrice[idx + 1];
            quantity[idx] = quantity[idx + 1];
        }
        cout << "Enter any key to return to previos section";
        getch();
    }
    cout << medCount << endl;
}
void calculateBill()
{
    system("cls");
    billheader();
    cout<<endl;
    cout<<endl;
    cout<<endl;
    for (int idx = 0; idx < medCount; idx++)
    {
        bill = orderedPrice[idx] * quantity[idx];
        final_bill = final_bill + bill;
    }
    if (final_bill >= 600 && final_bill < 1000)
    {
        final_bill = final_bill * 10 / 100;
        cout << "You are given 10% discount" << endl;
        cout << "Your bill is:" << final_bill << endl;
    }

    else if (final_bill >= 1000 && final_bill < 1500)
    {
        final_bill = final_bill * 20 / 100;
        cout << "You are given 20% discount" << endl;
        cout << "Your bill is:" << final_bill << endl;
    }
    else if (final_bill >= 1500)
    {
        final_bill = final_bill * 30 / 100;
        cout << "You are given 30% discount" << endl;
        cout << "Your bill is:" << final_bill << endl;
    }
    else
    {
        cout << "your final bill is =" << final_bill << endl;
    }
    getch();
}
int validateInput(string word) // function to validate numbers...
{
    int chk = 0;
    bool flag = false;

    for (int i = 0; i < word.length(); i++)
    {
        if (!(word[i] >= 48 && word[i] <= 57))
        {
            flag = true;
        }
    }

    if (word.length() > 9)
    {
        flag = true;
    }

    if (flag)
    {
        chk = -1;
    }
    else
    {
        for (int i = 0; i < word.length(); i++)
        {
            chk = chk * 10;
            chk = chk + (word[i] - 48);
        }
    }
    return chk;
}

int validateFunction(string name) // function to validate any name in upper and smaller case !
{
    int result = 0;
    bool flag = true;

    for (int i = 0; i < name.length(); i++)
    {
        if (!((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z')))
        {

            flag = false;
        }
    }
    if (name.length() > 10)
    {
        flag = false;
    }

    return flag;
}

bool validchoice(string choice)
{
    bool flag = false;
    for (int i = 0; i < 3; i++)
    {
        if (choice >= "0" && choice <= "3")
        {
            flag = true;
        }
        return flag;
    }
}
// bool validprice(string price_)
// {
//     bool flag = false;
//     for (int i = 0; i < price.length(); i++)
//     {
//         if (Price[i] >= 48 && Price[i] <= 57)
//         {
//             flag = true;
//         }
//         return flag;
//     }
// }

void header()
{
    cout << "                           d8b   d8,                  d8b                                                 " << endl;
    cout << "                           88P  `8P                   88P                    d8P                          " << endl;
    cout << "                          d88                        d88                  d888888P                        " << endl;
    cout << "  88bd8b,d88b  d8888b d888888    88b d8888b d888b8b  888           .d888b,  ?88'   d8888b   88bd88b d8888b" << endl;
    cout << "  88P'`?8P'?8bd8b_,dPd8P' ?88    88Pd8P' `Pd8P' ?88  ?88           ?8b,     88P   d8P' ?88  88P'  `d8b_,dP" << endl;
    cout << " d88  d88  88P88b    88b  ,88b  d88 88b    88b  ,88b  88b            `?8b   88b   88b  d88 d88     88b    " << endl;
    cout << "d88' d88'  88b`?888P'`?88P'`88bd88' `?888P'`?88P'`88b  88b        `?888P'   `?8b  `?8888P'd88'     `?888P'" << endl;
}

void adminheader()
{

    cout << "  @@@@@@  @@@@@@@  @@@@@@@@@@  @@@ @@@  @@@       @@@@@@  @@@@@@@ @@@@@@@  @@@@@@@@ @@@@@@@@ @@@  @@@" << endl;
    cout << " @@!  @@@ @@!  @@@ @@! @@! @@! @@! @@!@!@@@      !@@     !@@      @@!  @@@ @@!      @@!      @@!@!@@@" << endl;
    cout << " @!@!@!@! @!@  !@! @!! !!@ @!@ !!@ @!@@!!@!       !@@!!  !@!      @!@!!@!  @!!!:!   @!!!:!   @!@@!!@!" << endl;
    cout << " !!:  !!! !!:  !!! !!:     !!: !!: !!:  !            !:! :!!      !!: :!!  !!:      !!:      !!:  !!!" << endl;
    cout << "  :   : : :: :  :   :      :   :   ::    :       ::.: :   :: :: :  :   : : : :: ::: : :: ::: ::    : " << endl;
}
void userheader()
{
    cout << "  @@@@@@@ @@@  @@@  @@@@@@ @@@@@@@  @@@@@@  @@@@@@@@@@  @@@@@@@@ @@@@@@@         @@@@@@  @@@@@@@ @@@@@@@  @@@@@@@@ @@@@@@@@ @@@  @@@" << endl;
    cout << " !@@      @@!  @@@ !@@       @@!   @@!  @@@ @@! @@! @@! @@!      @@!  @@@       !@@     !@@      @@!  @@@ @@!      @@!      @@!@!@@@" << endl;
    cout << " !@!      @!@  !@!  !@@!!    @!!   @!@  !@! @!! !!@ @!@ @!!!:!   @!@!!@!         !@@!!  !@!      @!@!!@!  @!!!:!   @!!!:!   @!@@!!@!" << endl;
    cout << " :!!      !!:  !!!     !:!   !!:   !!:  !!! !!:     !!: !!:      !!: :!             !:! :!!      !!: :!!  !!:      !!:      !!:  !!!" << endl;
    cout << "  :: :: :  :.:: :  ::.: :     :     : :. :   :      :   : :: :::  :   :         ::.: :   :: :: :  :   : : : :: ::: : :: ::: ::    : " << endl;
}

void listheader()
{
    cout << " @@@@@@@@@@  @@@@@@@@ @@@@@@@  @@@  @@@@@@@ @@@ @@@  @@@ @@@@@@@@      @@@      @@@  @@@@@@ @@@@@@@" << endl;
    cout << " @@! @@! @@! @@!      @@!  @@@ @@! !@@      @@! @@!@!@@@ @@!           @@!      @@! !@@       @@!  " << endl;
    cout << " @!! !!@ @!@ @!!!:!   @!@  !@! !!@ !@!      !!@ @!@@!!@! @!!!:!        @!!      !!@  !@@!!    @!!  " << endl;
    cout << " !!:     !!: !!:      !!:  !!! !!: :!!      !!: !!:  !!! !!:           !!:      !!:     !:!   !!:  " << endl;
    cout << "  :      :   : :: ::: :: :  :  :    :: :: : :   ::    :  : :: :::      : ::.: : :   ::.: :     :   " << endl;
}

void deleteheader()
{
    cout << " @@@@@@@  @@@@@@@@ @@@      @@@@@@@@ @@@@@@@ @@@@@@@@      @@@@@@@@@@  @@@@@@@@ @@@@@@@  @@@  @@@@@@@ @@@ @@@  @@@ @@@@@@@@" << endl;
    cout << " @@!  @@@ @@!      @@!      @@!        @@!   @@!           @@! @@! @@! @@!      @@!  @@@ @@! !@@      @@! @@!@!@@@ @@!     " << endl;
    cout << " @!@  !@! @!!!:!   @!!      @!!!:!     @!!   @!!!:!        @!! !!@ @!@ @!!!:!   @!@  !@! !!@ !@!      !!@ @!@@!!@! @!!!:!  " << endl;
    cout << " !!:  !!! !!:      !!:      !!:        !!:   !!:           !!:     !!: !!:      !!:  !!! !!: :!!      !!: !!:  !!! !!:     " << endl;
    cout << " :: :  :  : :: ::: : ::.: : : :: :::    :    : :: :::       :      :   : :: ::: :: :  :  :    :: :: : :   ::    :  : :: :::" << endl;
}

void updateheader()
{

    cout << " @@@  @@@ @@@@@@@  @@@@@@@   @@@@@@  @@@@@@@ @@@@@@@@" << endl;
    cout << " @@!  @@@ @@!  @@@ @@!  @@@ @@!  @@@   @@!   @@!     " << endl;
    cout << " @!@  !@! @!@@!@!  @!@  !@! @!@!@!@!   @!!   @!!!:!  " << endl;
    cout << " !!:  !!! !!:      !!:  !!! !!:  !!!   !!:   !!:     " << endl;
    cout << "  :.:: :   :       :: :  :   :   : :    :    : :: :::" << endl;
}
void feedbackheader()
{


cout<<"            @@@@@@@ @@@  @@@ @@@@@@@@  @@@@@@@ @@@  @@@                 "<<endl;
cout<<"           !@@      @@!  @@@ @@!      !@@      @@!  !@@                 "<<endl;
cout<<"           !@!      @!@!@!@! @!!!:!   !@!      @!@@!@!                  "<<endl;
cout<<"           :!!      !!:  !!! !!:      :!!      !!: :!!                  "<<endl;
cout<<"            :: :: :  :   : : : :: :::  :: :: :  :   :::                 "<<endl;
cout<<"                                                                        "<<endl;
cout<<" @@@@@@@@ @@@@@@@@ @@@@@@@@ @@@@@@@  @@@@@@@   @@@@@@   @@@@@@@ @@@  @@@"<<endl;
cout<<" @@!      @@!      @@!      @@!  @@@ @@!  @@@ @@!  @@@ !@@      @@!  !@@"<<endl;
cout<<" @!!!:!   @!!!:!   @!!!:!   @!@  !@! @!@!@!@  @!@!@!@! !@!      @!@@!@! "<<endl;
cout<<" !!:      !!:      !!:      !!:  !!! !!:  !!! !!:  !!! :!!      !!: :!! "<<endl;
cout<<"  :       : :: ::: : :: ::: :: :  :  :: : ::   :   : :  :: :: :  :   :::"<<endl;
}
void cartheader()
{
cout<<"           @@@  @@@ @@@ @@@@@@@@ @@@  @@@  @@@       @@@@@@@  @@@@@@  @@@@@@@  @@@@@@@"<<endl;
cout<<"           @@!  @@@ @@! @@!      @@!  @@!  @@!      !@@      @@!  @@@ @@!  @@@   @@!  "<<endl;
cout<<"           @!@  !@! !!@ @!!!:!   @!!  !!@  @!@      !@!      @!@!@!@! @!@!!@!    @!!  "<<endl;
cout<<"            !: .:!  !!: !!:       !:  !!:  !!       :!!      !!:  !!! !!: :!!    !!:  "<<endl;
cout<<"              ::    :   : :: :::   ::.:  :::         :: :: :  :   : :  :   : :    :   "<<endl;
     }    
void billheader()
{
cout<<"           @@@@@@@  @@@@@@  @@@@@@@  @@@@@@  @@@           @@@@@@@  @@@ @@@      @@@ "<<endl;    
cout<<"             @@!   @@!  @@@   @@!   @@!  @@@ @@!           @@!  @@@ @@! @@!      @@!     "<<endl;
cout<<"             @!!   @!@  !@!   @!!   @!@!@!@! @!!           @!@!@!@  !!@ @!!      @!!     "<<endl;
cout<<"             !!:   !!:  !!!   !!:   !!:  !!! !!:           !!:  !!! !!: !!:      !!:     "<<endl;
cout<<"              :     : :. :     :     :   : : : ::.: :      :: : ::  :   : ::.: : : ::.: :"<<endl;
                                                                                         
}
void addheader() 
{
cout<<"            @@@@@@  @@@@@@@  @@@@@@@ "<<endl;
cout<<"           @@!  @@@ @@!  @@@ @@!  @@@"<<endl;
cout<<"           @!@!@!@! @!@  !@! @!@  !@!"<<endl;
cout<<"           !!:  !!! !!:  !!! !!:  !!!"<<endl;
cout<<"            :   : : :: :  :  :: :  : "<<endl;

}

         

                                     


