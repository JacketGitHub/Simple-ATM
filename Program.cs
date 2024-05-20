using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("~~~~~~~~~~~~~~~~WELCOME TO PRETEND ATM~~~~~~~~~~~~~~~~\n");

            Console.Write("Please input your PIN: ");
            int User_PIN = Convert.ToInt16(Console.ReadLine());
            if (User_PIN < 0)
            {
                Console.WriteLine("Your PIN cannot go into the negatives (how did you manage to do that even?). Try again.\n");
                return;
            }
            Console.Write("Please input your cash balance: ");
            decimal User_Cash_Money = Convert.ToDecimal(Console.ReadLine());
            if (User_Cash_Money < 0)
            {
                Console.WriteLine("Your account cannot go into the negatives (hopefully). Try again.\n");
                return;
            }


            while (true) 
            {
                Console.WriteLine("Please select an option:\n" +
                "1. Remaining balance\n" +
                "2. Cash withdrawal\n" +
                "3. Cash deposit\n" +
                "4. Change PIN\n" +
                "0. Quit");

                int User_Input = Convert.ToInt16(Console.ReadLine());

                if (User_Input == 0)
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }
                else if (User_Input == 1)
                {
                    Console.WriteLine("Your remaining balance is {0:0.00}.\n", User_Cash_Money);
                }
                else if (User_Input == 2)
                {
                    Console.Write("Please input your PIN to withdraw money: ");
                    int Input_PIN = Convert.ToInt16(Console.ReadLine()); //Input_PIN - Temp variable
                    if (Input_PIN == User_PIN)
                    {
                        Console.Write("Select amount you want to withdraw: ");
                        decimal Cash_Withdraw = Convert.ToDecimal(Console.ReadLine());
                        if (Cash_Withdraw < 0)
                        {
                            Console.WriteLine("You cannot withdraw negative money\n");
                        }
                        else if (Cash_Withdraw <= User_Cash_Money)
                        {
                            User_Cash_Money = User_Cash_Money - Cash_Withdraw;
                            Console.WriteLine("Current Balance is {0:0.00}.\n", User_Cash_Money);
                        }
                        else
                        {
                            Console.WriteLine("The requested withdrawal is larger than the current account balance.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your PIN is incorrect.\n");
                    }
                }
                else if (User_Input == 3)
                {
                    Console.Write("Please input your PIN to deposit money: ");
                    int Input_PIN = Convert.ToInt16(Console.ReadLine());
                    if (Input_PIN == User_PIN)
                    {
                        Console.Write("Select amount you want to deposit: ");
                        decimal Cash_Deposit = Convert.ToDecimal(Console.ReadLine());
                        if (Cash_Deposit < 0)
                        {
                            Console.WriteLine("You cannot deposit negative money\n");
                        }
                        else
                        {
                            User_Cash_Money = User_Cash_Money + Cash_Deposit;
                            Console.WriteLine("Current Balance is {0:0.00}.\n", User_Cash_Money);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your PIN is incorrect.\n");
                    }
                }
                else if (User_Input == 4)
                {
                    Console.Write("Please input old PIN: ");
                    int Input_PIN = Convert.ToInt16(Console.ReadLine());
                    if (Input_PIN == User_PIN)
                    {
                        Console.Write("Please input new PIN: ");
                        int New_PIN = Convert.ToInt16(Console.ReadLine());
                        if (New_PIN < 0)
                        {
                            Console.WriteLine("New PIN is invalid, try again.\n");
                        }
                        else
                        {
                            User_PIN = New_PIN;
                            Console.WriteLine("Your PIN has been changed.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is not your old PIN, try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine("This is not a valid option, please select a valid option\n");
                }
            }        
        }
    }
}
