using Bonus_Lab;
using System.Diagnostics;
using System.Reflection;





class Program
{
    static void Main(string[] args)
    {
        bool askAgain = true;
        string name;
        int number;

        do
        {
            Console.WriteLine("Enter Customer Name");
            name = Console.ReadLine();


        }
        while (int.TryParse(name, out number) || string.IsNullOrEmpty(name));

        Checking checkac = new Checking(name, 0); //create Checking account object
        Saving saveac = new Saving(name, 0); //create Saving account object
        string acselect = "\n Select the account:\n 1. Checking Account\n 2. Saving Account";

        while (askAgain) //run the program untill user decides to exit
        {
            Console.WriteLine("\n Please select activity:\n 1. Deposit...\n 2. Withdrawal...\n 3. Transfer...\n 4. Activity Enquiry...\n 5. Balance Enquiry\n 6. Exit...\n");
            int selection = 0;
            while (selection < 1 || selection > 6) //check the activity user chooses
            {
                Console.Write("\nEnter your selection (1 to 6): ");
                if ((!int.TryParse(Console.ReadLine(), out selection)) || (selection < 1 || selection > 6))
                {
                    Console.WriteLine("\nPlease enter the valid number (1-6)");

                }
            }

            switch (selection)
            {
                case 1://deposit

                    string choice;//for checking 
                    string choice2;//for checking 
                    int inputD; //to choose the account
                    double amountD;//amount to deposit


                    do//check if the account selected properly
                    {
                        Console.WriteLine(acselect);
                        choice = Console.ReadLine();

                    }
                    while (!int.TryParse(choice, out inputD) || inputD < 1 || inputD > 2);



                    do//check if the amount entered properly
                    {
                        Console.WriteLine("Enter Amount: ");
                        choice2 = Console.ReadLine();
                    }
                    while (!double.TryParse(choice2, out amountD) || (amountD < 0));

                    if (inputD == 1)//checking account
                    {
                        checkac.Deposit(amountD, false);
                        Console.WriteLine($"Deposit completed, Checking account current balance: {checkac.Balance:C2}");
                    }
                    if (inputD == 2)//saving account
                    {
                        saveac.Deposit(amountD, false);
                        Console.WriteLine($"Deposit completed, Saving account current balance: {saveac.Balance:C2}");
                    }
                    break;

                case 2://withdraw
                    string choice3;//for checking 
                    string choice4;//for checking 
                    int inputW; //to choose the account
                    double amountW;// amount to withdraw

                    do
                    {
                        Console.WriteLine(acselect);
                        choice3 = Console.ReadLine();
                    }
                    while (!int.TryParse(choice3, out inputW) || inputW < 1 || inputW > 2);


                    do
                    {
                        Console.WriteLine("Enter Amount:");
                        choice4 = Console.ReadLine();
                    }
                    while (!double.TryParse(choice4, out amountW) || (amountW < 0));

                    if (inputW == 1)//checking
                    {
                        checkac.Withdraw(amountW, false);
                        if (amountW <= 300 && checkac.Balance > amountW)
                        {
                            Console.WriteLine($"Withdraw completed, Checking account current balance: {checkac.Balance:C2}");
                        }

                    }
                    if (inputW == 2)//saving
                    {


                        if (amountW + 10 < saveac.Balance)
                        {
                            saveac.Withdraw(amountW, false);
                            saveac.ApplyPenalty(10);
                            Console.WriteLine($"Withdraw completed, Saving account current balance: {saveac.Balance:C2}");
                        }
                        else
                        {
                            Console.WriteLine($"Insuffisient funds. Saving account current balance: {saveac.Balance:C2}");
                        }

                    }
                    break;
                case 3:
                    string choice5;//checking
                    int userTransferChoice;

                    do
                    {
                        Console.Write("\nSelect accounts(1 - from Checking to Saving; 2 - from Saving to Checking): ");
                        choice5 = Console.ReadLine();
                    } while (!int.TryParse(choice5, out userTransferChoice) || userTransferChoice < 1 || userTransferChoice > 2);

                    //int userTransferChoice = int.Parse(Console.ReadLine());
                    double amountT;
                    string choice6;//for checking

                    do
                    {
                        Console.WriteLine("Enter Amount:");
                        choice6 = Console.ReadLine();
                    }
                    while (!double.TryParse(choice6, out amountT) || (amountT < 0));


                    if (userTransferChoice == 1)
                    {

                        if (amountT <= checkac.Balance)
                        {
                            checkac.Transfer(amountT, saveac);
                            Console.WriteLine("Transfer completed");
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient funds. Chacking account balance: {checkac.Balance:C2}");
                        }


                    }
                    else if (userTransferChoice == 2)
                    {
                        if (amountT + 10 < saveac.Balance)
                        {
                            saveac.Transfer(amountT, checkac);
                            saveac.ApplyPenalty(10);
                            Console.WriteLine("Transfer completed");
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient funds. Saving account balance: {saveac.Balance:C2}");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please select 1 or 2");
                    }

                    //transfer
                    break;

                case 4://Activity Enquiry
                    Console.WriteLine("Checking Account:");
                    checkac.DisplayTransactions();
                    Console.WriteLine("Saving Account:");
                    saveac.DisplayTransactions();

                    break;
                case 5://Current Balance
                    Console.WriteLine("Current balance:");
                    Console.WriteLine($"Saving balance is{saveac.Balance:C2}");
                    Console.WriteLine($"Checking balance is{checkac.Balance:C2}");
                    break;
                case 6://exit
                    Console.WriteLine("Thank you for using Algonquin Banking System!");
                    askAgain = false;
                    break;

            }
        }
    }
}

