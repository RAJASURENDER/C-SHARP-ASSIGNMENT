// task1 : Loan eligibility check


class LoanEligibilityChecker
{
   static void Main()
    {
        Console.Write("Enter customer's credit score: ");
       int creditScore = Convert.ToInt32(Console.ReadLine());

       Console.Write("Enter customer's annual income: $");
       double annualIncome = Convert.ToDouble(Console.ReadLine());

       if (creditScore > 700 && annualIncome >= 50000)
       {
            Console.WriteLine("\nCongratulations! The customer is eligible for a loan.");
        }
       else
        {
           Console.WriteLine("\nSorry, the customer is not eligible for a loan based on the given criteria.");
        }
    }
};


//Task2 :Simulating ATM TRANSACTION

class Program
{
    static void Main()
    {
        Console.Write("Enter your current balance: $");
        double currentBalance = double.Parse(Console.ReadLine());

        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Deposit");


        Console.Write("Enter your choice (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine($"Your current balance is: ${currentBalance}");
        }

        else if (choice == 2)
        {
            Console.Write("Enter the amount to withdraw: $");
            double withdrawAmount = double.Parse(Console.ReadLine());

            if (withdrawAmount > currentBalance || (withdrawAmount % 100 != 0 && withdrawAmount % 500 != 0))
            {
                Console.WriteLine("Withdrawal failed. Invalid amount or insufficient funds.");
            }
            else
            {
                currentBalance -= withdrawAmount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: ${currentBalance}");
            }
        }

        else if (choice == 3)
        {
            Console.Write("Enter the amount to deposit: $");
            double depositAmount = double.Parse(Console.ReadLine());

            if (depositAmount <= 0)
            {
                Console.WriteLine("Deposit failed. Invalid amount.");
            }
            else
            {
                currentBalance += depositAmount;
                Console.WriteLine($"Deposit successful. Updated balance: ${currentBalance}");
            }
        }
       else        {
            Console.WriteLine("Invalid choice. Please select a valid option (1-3).");
        }
    }
}; 



