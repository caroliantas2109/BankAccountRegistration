using System;

class BankAccount
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string AccountType { get; set; }

    // TO DO
    // Create 3 constructors that use constructor chaining:

    // - constructor for when you have the user's name only

    public BankAccount(string name)
    {
        Name = name;
        Balance = 0;
        AccountType = "Standard"; 
    }


    // - constructor for when you have the user's name and balance (but not account type)
    
    public BankAccount(string name, double balance) : this(name)
    {
        Balance = balance;
    }
      
    // - constructor for when you have the user's name, balance, and account type

    public BankAccount(string name, double balance, string accountType) :this(name, balance)
    {
        AccountType = accountType;
    }

    // TO DO
    // Create a method to display Name, Balance, and AccountType

    public void DisplayInfo()
    {
        Console.WriteLine("Name: {0}, Balance: ${1}, Account Type: {2}", Name, Balance, AccountType);

    }
   
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the account holder's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter a starting balance: ");
        string balanceInput = Console.ReadLine();

        Console.Write("Enter an account type (or leave blank for 'Standard'): ");
        string accountType = Console.ReadLine();


        // TO DO
        // Attempt to convert 'balanceInput' to a double

        double balance;
        bool isBalanceValid = double.TryParse(balanceInput, out balance);


        // TO DO
        // Create a new bank account
        // Call the appropriate constructor depending on the validity of the 3 user inputs

        BankAccount account;

        if (isBalanceValid && !string.IsNullOrWhiteSpace(accountType))
        {
            account = new BankAccount(name, balance, accountType);
        }
        else if (isBalanceValid)
        {
            account = new BankAccount(name, balance, accountType);
        }
        else
        {
            Console.WriteLine("Invalid input for balance. Defaulting to $0.");
            account = new BankAccount(name);        
        }

        // TO DO
        // After the account has been created, display its details

        Console.WriteLine("Account created!");
        account.DisplayInfo();
    
    
    
    }
}