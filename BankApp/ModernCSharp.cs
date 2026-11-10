
using System;
using System.Collections.Generic;
using System.Linq;

// SECTION 8.1: ENUM
// Represents a fixed set of named values.

public enum TransactionType
{
    Deposit,
    Withdrawal,

}

public enum TransactionStatus
{
    Pending,
    Successful,
    Rejected
}


// SECTION 8.2: STRUCT
// Groups related values into a value type.

public readonly struct AccountStatistics
{
    public int TransactionCount { get; }
    public decimal TotalDeposits { get; }
    public decimal TotalWithdrawals { get; }

    public AccountStatistics(
        int transactionCount,
        decimal totalDeposits,
        decimal totalWithdrawals)
    {
        TransactionCount = transactionCount;
        TotalDeposits = totalDeposits;
        TotalWithdrawals = totalWithdrawals;
    }
}


// SECTION 8.3: RECORD
// Stores transaction data in a concise data-focused type.

public record BankTransaction(
    int TransactionId,
    TransactionType Type,
    decimal Amount,
    string Description,
    DateTime TransactionDate,
    TransactionStatus Status);


// SECTION 8: MODERN C# DEMONSTRATION CLASS

public class ModernCSharpDemo
{    
    private readonly List<BankTransaction> transactions = new();

   
    // ==========================================
    // SECTION 8.1: ENUM
    // ==========================================

    private void DemonstrateEnum()
    {
        Console.WriteLine("\n8.1 ENUM");

        TransactionType type = TransactionType.Deposit;

        TransactionStatus status = TransactionStatus.Successful;

        Console.WriteLine($"Transaction Type: {type}");
        Console.WriteLine($"Transaction Status: {status}");

        if (status == TransactionStatus.Successful)
        {
            Console.WriteLine("Transaction completed successfully.");
        }
    }


    // ==========================================
    // SECTION 8.2: STRUCT
    // ==========================================

    private void DemonstrateStruct()
    {
        Console.WriteLine("\n8.2 STRUCT");

        AccountStatistics statistics = GetAccountStatistics();

        Console.WriteLine($"Transaction Count: {statistics.TransactionCount}");
        Console.WriteLine($"Total Deposits: ₹{statistics.TotalDeposits}");
        Console.WriteLine($"Total Withdrawals: ₹{statistics.TotalWithdrawals}");
    }

    private AccountStatistics GetAccountStatistics()
    {
        return new AccountStatistics(
            4,
            5000m,
            2000m
        );
    }


    // ==========================================
    // SECTION 8.3: RECORD
    // ==========================================

    private void DemonstrateRecord()
    {
        Console.WriteLine("\n8.3 RECORD");

        // Creating transaction records.
        transactions.Add(new BankTransaction(
            1,
            TransactionType.Deposit, //enum representation
            3000m,
            "Salary Credit",
            DateTime.Now,
            TransactionStatus.Successful //enum representation
        ));

        transactions.Add(new BankTransaction(
            2,
            TransactionType.Withdrawal,
            1000m,
            "ATM Withdrawal",
            DateTime.Now,
            TransactionStatus.Successful
        ));

        transactions.Add(new BankTransaction(
            3,
            TransactionType.Deposit,
            2000m,
            "Cash Deposit",
            DateTime.Now,
            TransactionStatus.Successful
        ));

        transactions.Add(new BankTransaction(
            4,
            TransactionType.Withdrawal,
            1000m,
            "Invalid Withdrawal",
            DateTime.Now,
            TransactionStatus.Rejected
        ));

        foreach (BankTransaction transaction in transactions)
        {
            Console.WriteLine(
                $"ID: {transaction.TransactionId}, " +
                $"Type: {transaction.Type}, " +
                $"Amount: ₹{transaction.Amount}, " +
                $"Description: {transaction.Description}, " +
                $"Status: {transaction.Status}"
            );
        }
    }


    // ==========================================
    // SECTION 8.4: TUPLE
    // ==========================================

    private void DemonstrateTuple()
    {
        Console.WriteLine("\n8.4 TUPLE");

        var summary = GetAccountSummary();

        Console.WriteLine($"Account Holder: {summary.AccountHolder}");
        Console.WriteLine($"Account Number: {summary.AccountNumber}");
        Console.WriteLine($"Balance: ₹{summary.Balance}");
        Console.WriteLine($"Transaction Count: {summary.TransactionCount}");
         Console.WriteLine($"isactive: {summary.isactive}");
    }

    private (string AccountHolder, string AccountNumber,
        decimal Balance, int TransactionCount, bool isactive) GetAccountSummary()
    {
        return ("Rahul", "SB1001", 10000m, transactions.Count, true);
    }


    // ==========================================
    // SECTION 8.5: PATTERN MATCHING
    // ==========================================

    private void DemonstratePatternMatching()
    {
        Console.WriteLine("\n8.5 PATTERN MATCHING");

        foreach (BankTransaction transaction in transactions)
        {
            string message = transaction switch
            {
                { Status: TransactionStatus.Rejected } =>
                    "Transaction was rejected.",

                { Type: TransactionType.Deposit, Amount: > 0 } =>
                    "Money was deposited.",

                { Type: TransactionType.Withdrawal, Amount: > 0 } =>
                    "Money was withdrawn.",

                _ => "Unknown transaction."
            };

            Console.WriteLine(message);
        }
    }


    // ==========================================
    // SECTION 8.6: GENERICS
    // ==========================================
    
    private void DemonstrateGenerics()
    {
        Console.WriteLine("\n8.6 GENERICS");


        

        List<string> accountHolders = new()
        {
            "Rahul",
            "Priya",
            "Arun",
            "John"
        };

        List<int> accountNumbers = new()
        {
            1001,
            1002,
            1003,
            1004
        };

        List<decimal> transactionAmounts = new()
        {
            3000m,
            1000m,
            2000m,
            1000m
        };

        DisplayItems(accountHolders, "ACCOUNT HOLDERS");

        DisplayItems(accountNumbers, "ACCOUNT NUMBERS");

        DisplayItems(transactionAmounts, "TRANSACTION AMOUNTS");
    }


    // Generic method.
    // T can represent different data types.

    private void DisplayItems<T>(List<T> items, string title)
    {
        Console.WriteLine($"\n{title}");

        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }

    // ==========================================
    // SECTION 10: EXCEPTION HANDLING
    // ==========================================

    private void DemonstrateExceptionHandling()
    {
        Console.WriteLine("\n10. EXCEPTION HANDLING");

        decimal balance = 5000m;

        try
        {
            balance += 2000m;
            Console.WriteLine("Deposited: ₹2000");

            decimal withdrawal = 10000m;

            if (withdrawal > balance)
            {
                throw new Exception("Insufficient balance!");
            }

            balance -= withdrawal;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Transaction process completed.");
        }

        Console.WriteLine($"Available Balance: ₹{balance}");
    }

       // ==========================================
    // SECTION 13: DELEGATES AND EVENTS
    // ==========================================

    // 1.Event declaration
    public event Action<string>? TransactionCompleted;
    //2.Method that handles the event
    private void SendMessage(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
    private void DemonstrateDelegatesAndEvents()
    {
         Console.WriteLine("\n13. DELEGATES AND EVENTS");

        // // Delegate: stores a reference to a method.
        // Action<string> notification = DisplayMessage;

        // notification("Welcome to our bank!");

        // 3.Subscribe to the event.
        TransactionCompleted += SendMessage;

        // // Subscribe using a lambda expression.
        // TransactionCompleted += message =>
        //     Console.WriteLine($"Email: {message}");

        // 4.Raise the event.        
        TransactionCompleted?.Invoke(
            "₹5000 deposited successfully.");

        // // Func: accepts inputs and returns a value.
        // Func<decimal, decimal, decimal> calculateInterest =
        //     (amount, rate) => amount * rate / 100;

        // Console.WriteLine(
        //     $"Interest: ₹{calculateInterest(10000m, 5m)}");

        // // Action: accepts input but returns nothing.
        // Action<string> display =
        //     message => Console.WriteLine(message);

        // display("Account is active.");
    }

   

     // ==========================================
    // SECTION 14: ASYNCHRONOUS PROGRAMMING
    // ==========================================

    private async Task DemonstrateAsync()
    {
        Console.WriteLine("\n14. ASYNCHRONOUS PROGRAMMING");

        Console.WriteLine("Fetching account balance...");

        decimal balance = await GetBalanceAsync();

        Console.WriteLine($"Account Balance: ₹{balance}");

        Console.WriteLine("Balance fetched successfully.");
        
    }

    // Task represents an asynchronous operation.
    private async Task<decimal> GetBalanceAsync()
    {
        // Simulates waiting for a bank server response.
        await Task.Delay(2000);

        return 15000m;
    }

     // ==========================================
    // SECTION 15: MEMORY MANAGEMENT
    // ==========================================

    private void DemonstrateMemoryManagement()
    {
        Console.WriteLine("\n15. MEMORY MANAGEMENT");

        // VALUE TYPE
        int balance1 = 5000;

        int balance2 = balance1;

        balance2 = 10000;

        Console.WriteLine($"Balance 1: ₹{balance1}");
        Console.WriteLine($"Balance 2: ₹{balance2}");


        // REFERENCE TYPE
        Customer customer1 = new Customer();

        customer1.Name = "Rahul";

        Customer customer2 = customer1;

        customer2.Name = "Priya";

        Console.WriteLine($"Customer 1: {customer1.Name}");
        Console.WriteLine($"Customer 2: {customer2.Name}");


        // BOXING
        int accountNumber = 1001;

        object boxedValue = accountNumber;

        Console.WriteLine($"Boxed Value: {boxedValue}");


        // UNBOXING
        int unboxedValue = (int)boxedValue;

        Console.WriteLine($"Unboxed Value: {unboxedValue}");


        // GARBAGE COLLECTION
        customer1 = null!;
        customer2 = null!;

        Console.WriteLine(
            "Customer references cleared. .NET manages unused objects.");
    }


    // Simple reference type for memory demonstration.
    private class Customer
    {
        public string Name { get; set; } = "";
    }

    // ==========================================
    // MAIN METHOD TO RUN ALL DEMONSTRATIONS
    // ==========================================

    public async Task RunAsync()
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine("    ADDITIONAL C# CONCEPTS");
        Console.WriteLine("==================================");

       DemonstrateEnum();

        DemonstrateStruct();

        DemonstrateRecord();

        DemonstrateTuple();

        DemonstratePatternMatching();

         DemonstrateGenerics();

        DemonstrateExceptionHandling();

        DemonstrateDelegatesAndEvents();

        await DemonstrateAsync();

        DemonstrateMemoryManagement();

        Console.WriteLine("\nAll demonstrations completed.");
    }
}

