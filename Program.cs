using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9_ProjectDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients client = new Clients();
            Accounts account = new Accounts();
            CheckingAccount checking = new CheckingAccount();
            ReserveAccount reserve = new ReserveAccount();
            SavingsAccount savings = new SavingsAccount();
            StreamWriter checkingFile = new StreamWriter("CheckingSummary.txt");
            StreamWriter reserveFile = new StreamWriter("ReserveSummary.txt");
            StreamWriter savingsFile = new StreamWriter("SavingsSumary.txt");
            DateTime date = DateTime.Now;
            using (checkingFile)
            using (reserveFile)
            using (savingsFile)
            {
                checkingFile.WriteLine(client.Header());
                checkingFile.WriteLine("Account number: "+checking.AccountNumber);
                reserveFile.WriteLine(client.Header());
                reserveFile.WriteLine("Account number: "+reserve.AccountNumber);
                savingsFile.WriteLine(client.Header());
                savingsFile.WriteLine("Account number: "+savings.AccountNumber);
                while (true)
                {
                    Title();
                    DisplayMenu();
                    string choice = Console.ReadLine();
                    int menuChoice;
                    bool result = int.TryParse(choice, out menuChoice);

                    if (result == true)
                    {
                        if (menuChoice == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Goodbye");
                            Console.WriteLine("Press any to close");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            switch (menuChoice)
                            {
                                case 1:// this is the view client information section, will need to call the client class
                                    Console.Clear();
                                    Title();
                                    Console.WriteLine("Name:" + client.Name);
                                    Console.WriteLine("Address: " + client.Address);
                                    Console.WriteLine("Phone: " + client.PhoneNum);
                                    
                                    ReturnToMain();
                                    break;
                                case 2: // This is the view account balance section, will need to call the accounts class here
                                    Console.Clear();
                                    Title();
                                    DisplaySubMenu();
                                    string selector = Console.ReadLine();
                                    bool res = int.TryParse(selector, out menuChoice);
                                    if (res == true)
                                    {
                                        switch (menuChoice)
                                        {
                                            case 1: // checking account
                                                Console.WriteLine("Account Number:" + checking.AccountNumber);
                                                Console.WriteLine("Balance: " + "$" + checking.Balance);
                                                break;
                                            case 2: //reserve account
                                                Console.WriteLine("Account Number: " + reserve.AccountNumber);
                                                Console.WriteLine("Balance: " + "$" + reserve.Balance);
                                                break;
                                            case 3: // savings account
                                                Console.WriteLine("Account Number: " + savings.AccountNumber);
                                                Console.WriteLine("Balance: " + "$" + savings.Balance);
                                                break;
                                            case 4:
                                                Console.WriteLine("Press Any Key to Continue");
                                                ReturnToMain();
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Entry, Press any key to return the main menu");
                                                ReturnToMain();
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Entry, Press any key to return the main menu");
                                        ReturnToMain();
                                        break;
                                    }
                                    ReturnToMain();
                                    break;
                                case 3: // this is the deposit funds section, Deposit method is containted in the accounts class
                                    Console.Clear();
                                    Title();
                                    DisplaySubMenu();
                                    string s = Console.ReadLine();
                                    bool r = int.TryParse(s, out menuChoice);
                                    if (r == true)
                                    {
                                        switch (menuChoice)
                                        {
                                            case 1: // checking account
                                                checkingFile.Write("Starting Balance: " + "$" + checking.Balance);
                                                decimal checkingDepositAmt = checking.GetDepositAmt();
                                                checking.DepositFunds(checkingDepositAmt);
                                                checkingFile.Write(" + " + "$" + checkingDepositAmt);
                                                checkingFile.Write(" Balance: " + "$" + checking.Balance + " " + date);
                                                checkingFile.WriteLine(" ");
                                                break;
                                            case 2: //reserve account
                                                reserveFile.Write("Starting Balance: " + "$" + reserve.Balance);
                                                decimal reserveDepositAmt = reserve.GetDepositAmt();
                                                reserve.DepositFunds(reserveDepositAmt);
                                                reserveFile.Write(" + " + "$" + reserveDepositAmt);
                                                reserveFile.Write(" Balance: " + "$" + reserve.Balance + " " + date);
                                                reserveFile.WriteLine(" ");
                                                break;
                                            case 3: // savings account
                                                savingsFile.Write("Starting Balance: " + "$" + savings.Balance);
                                                decimal savingsDepositAmt = savings.GetDepositAmt();
                                                savings.DepositFunds(savingsDepositAmt);
                                                savingsFile.Write(" + " + "$" + savingsDepositAmt);
                                                savingsFile.Write(" Balance: " + "$" + savings.Balance + " " + date);
                                                savingsFile.WriteLine(" ");
                                                break;
                                            case 4:
                                                Console.WriteLine("Press Any Key to Continue");
                                                ReturnToMain();
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Entry, Press any key to return the main menu");
                                                ReturnToMain();
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Entry, Press any key to return the main menu");
                                        ReturnToMain();
                                        break;
                                    }
                                    ReturnToMain();
                                    break;
                                case 4: // this is the Withdraw funds sections, Withdraw method is in the accounts class
                                    Console.Clear();
                                    Title();
                                    DisplaySubMenu();
                                    string x = Console.ReadLine();
                                    bool y = int.TryParse(x, out menuChoice);
                                    if (y == true)
                                    {
                                        switch (menuChoice)
                                        {
                                            case 1: // checking account
                                                checkingFile.Write("Starting Balance: " + "$" + checking.Balance);
                                                decimal checkingWithDrawAmt = checking.GetWithDrawAmt();
                                                checking.WithdrawFunds(checkingWithDrawAmt);
                                                checkingFile.Write(" + " + "$" + checkingWithDrawAmt);
                                                checkingFile.Write(" Balance: " + "$" + checking.Balance + " " + date);
                                                checkingFile.WriteLine(" ");
                                                break;
                                            case 2: //reserve account
                                                reserveFile.Write("Starting Balance: " + "$" + reserve.Balance);
                                                decimal reserveWithDrawAmt = reserve.GetWithDrawAmt();
                                                reserve.WithdrawFunds(reserveWithDrawAmt);
                                                reserveFile.Write(" + " + "$" + reserveWithDrawAmt);
                                                reserveFile.Write(" Balance: " + "$" + reserve.Balance + " " + date);
                                                reserveFile.WriteLine(" ");
                                                break;
                                            case 3: // savings account
                                                savingsFile.Write("Starting Balance: " + "$" + savings.Balance);
                                                decimal savingsWithDrawAmt = savings.GetWithDrawAmt();
                                                savings.WithdrawFunds(savingsWithDrawAmt);
                                                savingsFile.Write(" + " + "$" + savingsWithDrawAmt);
                                                savingsFile.Write(" Balance: " + "$" + savings.Balance + " " + date);
                                                savingsFile.WriteLine(" ");
                                                break;
                                            case 4:
                                                Console.WriteLine("Press Any Key to Continue");
                                                ReturnToMain();
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Entry, Press any key to return the main menu");
                                                ReturnToMain();
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Entry, Press any key to return the main menu");
                                        ReturnToMain();
                                        break;
                                    }
                                    ReturnToMain();
                                    break;
                                default:// puts something for an error here
                                    Console.Clear();
                                    Title();
                                    Console.WriteLine("Error Invalid Entry");
                                    ReturnToMain();
                                    break;

                            }
                        }
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter the number of the Menu item you wish to choose");
                        ReturnToMain();
                    }
                }
            }
        }

        static void Title()// prints the project title to the screen
        {
            Console.WriteLine("***Bank Account System***\n\n\n");
        }
        static void ReturnToMain() // clears the console before returning to the main menu
        {
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
        static void DisplayMenu() // display's the main menu
        {
            string[] menu = { "Main Menu", "1- View Client Information", "2-View Account Balance", "3-Deposit Funds", "4- Withdraw Funds", "5- Exit" };
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine("Enter a menu option");
        }
        static void DisplaySubMenu()// displays the sub menu where you can decide which account to view
        {
            string[] subMenu = { "Select which Account", "1- Checking", "2- Reserve", "3-Savings", "4-Return to the Previous Menu" };
            for (int i = 0; i < subMenu.Length; i++)
            {
                Console.WriteLine(subMenu[i]);
            }
            Console.WriteLine("Enter a menu option");
        }
    }
}
