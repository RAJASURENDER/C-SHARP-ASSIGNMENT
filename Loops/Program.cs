// TASK 3: Calculating Compound interest and displaying future balance


class Program
{
    static void Main()
    {
        Console.Write("Enter the number of customers: ");
        int numberOfCustomers = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfCustomers; i++)
        {
            Console.WriteLine($"\nCustomer {i}");

            Console.Write("Enter initial balance: $");
            double initialBalance = double.Parse(Console.ReadLine());

            Console.Write("Enter annual interest rate (%): ");
            double annualInterestRate = double.Parse(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int numberOfYears = int.Parse(Console.ReadLine());

            double interestRateDecimal = annualInterestRate / 100;


            double futureBalance = initialBalance * Math.Pow(1 + interestRateDecimal, numberOfYears);

            Console.WriteLine($"Future Balance after {numberOfYears} years: ${futureBalance}");
        }
    }

}; 

//TASK 4 :DISPLAYING ACCOUNT BALANCE BY LOOP



class BankProgram
{
    // Simple class to represent a bank account
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
    }

    static void Main()
    {
        // Create a list to store customer accounts
        List<BankAccount> accounts = new List<BankAccount>
        {
            new BankAccount { AccountNumber = 12345, Balance = 1000.50 },
            new BankAccount { AccountNumber = 67890, Balance = 500.75 }
        };

        do
        {
            Console.Write("Enter your account number: ");
            if (int.TryParse(Console.ReadLine(), out int accountNumber))
            {
                // Validate the account number
                BankAccount customerAccount = accounts.Find(acc => acc.AccountNumber == accountNumber);

                if (customerAccount != null)
                {
                    // Display the account balance if the account number is valid
                    Console.WriteLine($"Account Number: {customerAccount.AccountNumber}, Balance: {customerAccount.Balance:C}");
                    break; // Exit the loop as a valid account number was entered
                }
                else
                {
                    Console.WriteLine("Invalid account number. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid account number.");
            }
        } while (true);
    }
} 

// TASK5 : PASSWORD VALIDATION-- CREATING PASSWORD



class PasswordValidationProgram
{
    static void Main()
    {
        Console.WriteLine("Create a password for your bank account:");

        while (true)
        {
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (IsPasswordValid(password))
            {
                Console.WriteLine("Password is valid. Thank you!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid password. Please follow the password rules.");
            }
        }
    }

    static bool IsPasswordValid(string password)
    {
        if (password.Length < 8)
        {
            Console.WriteLine("Password must be at least 8 characters long.");
            return false;
        }

        if (!ContainsUppercaseLetter(password))
        {
            Console.WriteLine("Password must contain at least one uppercase letter.");
            return false;
        }

        if (!ContainsDigit(password))
        {
            Console.WriteLine("Password must contain at least one digit.");
            return false;
        }
        return true;
    }

    static bool ContainsUppercaseLetter(string input)
    {
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                return true;
            }
        }
        return false;
    }

    static bool ContainsDigit(string input)
    {
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}


// TASK 6 : PASSWORD VALIDATION



class BankTransactionProgram
{
    static void Main()
    {
        List<string> transactionHistory = new List<string>();

        Console.WriteLine("Welcome to the Bank Transaction Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter deposit amount: $");
                    double depositAmount = GetValidAmount();
                    transactionHistory.Add($"Deposit: +${depositAmount}");
                    Console.WriteLine("Deposit successful!");
                    break;

                case "2":
                    Console.Write("Enter withdrawal amount: $");
                    double withdrawalAmount = GetValidAmount();
                    transactionHistory.Add($"Withdrawal: -${withdrawalAmount}");
                    Console.WriteLine("Withdrawal successful!");
                    break;

                case "3":
                    Console.WriteLine("\nTransaction History:");
                    foreach (string transaction in transactionHistory)
                    {
                        Console.WriteLine(transaction);
                    }
                    Console.WriteLine("\nThank you for using the Bank Transaction Program!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                    break;
            }
        }
    }

    static double GetValidAmount()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double amount) && amount >= 0)
            {
                return amount;
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a non-negative numeric value.");
            }
        }
    }
};
