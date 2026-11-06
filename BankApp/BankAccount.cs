
namespace BankApp;


// ======================================================
// CONCEPT 1: CLASSES AND OBJECTS
// A class is a blueprint used to create objects.
// ======================================================

public class BankAccount : AbstractBankAccount //deposit ,  interface also have deposit
{
    public BankAccount(
        string accountNumber,
        string accountHolder,
        decimal balance)
        : base(accountNumber, accountHolder, balance)
    {
    }

    public override decimal CalculateMonthlyBenefit()
    {
        return 0;
    }


    // ==================================================
    // CONCEPT 2: ENCAPSULATION
    // Encapsulation protects data and controls how it is accessed or modified.
    // ==================================================

    // Balance is protected inside AbstractBankAccount.
    // Deposit and Withdraw provide controlled access.


    // ==================================================
    // CONCEPT 5: METHOD OVERLOADING AND OVERRIDING
    // Overloading changes parameters; overriding changes inherited method behavior.
    // ==================================================

    // Method Overloading
    public void Deposit(decimal amount, string description)
    {
        Deposit(amount);

        if (amount > 0)
        {
            Console.WriteLine($"Transaction Details: {description}");
        }
    }


    // ==================================================
    // CONCEPT 4: POLYMORPHISM
    // Polymorphism allows the same method call to produce different behaviors.
    // ==================================================

    public virtual decimal CalculateMonthlyCharge()
    {
        return 15;
    }
}


// ======================================================
// CONCEPT 3: INHERITANCE
// Inheritance allows one class to reuse properties and methods of another class.
// ======================================================

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(
        string accountNumber,
        string accountHolder,
        decimal balance,
        decimal interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        InterestRate = interestRate;
    }


    // Method Overriding
    public override decimal CalculateMonthlyCharge()
    {
        return 10;
    }


    // Abstract method implementation
    public override decimal CalculateMonthlyBenefit()
    {
        return Balance * InterestRate / 100;
    }
}


public class CurrentAccount : BankAccount
{
    public string BusinessName { get; set; }

    public CurrentAccount(
        string accountNumber,
        string accountHolder,
        decimal balance,
        string businessName)
        : base(accountNumber, accountHolder, balance)
    {
        BusinessName = businessName;
    }

    public override decimal CalculateMonthlyCharge()
    {
        return 25;
    }

    public override decimal CalculateMonthlyBenefit()
    {
        return 0;
    }
}


// ======================================================
// CONCEPT 6: ABSTRACT CLASSES
// Abstract classes provide a common foundation and require child classes to implement abstract methods.
// ======================================================

public abstract class AbstractBankAccount : IAccount //2 mthodss
{
    // Encapsulation: Private balance field
    private decimal balance;

    public string AccountNumber { get; set; }
    public string AccountHolder { get; set; }

    // Read-only balance
    public decimal Balance
    {
        get { return balance; } //returning the private modifier balance
    }

    // Constructor
    public AbstractBankAccount(
        string accountNumber,
        string accountHolder,
        decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;

        balance = initialBalance >= 0 ? initialBalance : 0;
    }

    // var abs = new AbstractBankAccount("123","john")

    // Deposit operation
    public void Deposit(decimal amount) //signature
    {
        if (amount <= 0) //if this condition is true
        {
            Console.WriteLine("Invalid deposit amount!");
            return;
        }
        else
        {
             balance += amount; // storing/updateing the balance           
             Console.WriteLine($"Deposited: ₹{amount}");
        }
       
    }

    // Withdraw operation
    public void Withdraw(decimal amount)
    {
        //balance = 200 and u want to witdraw of amount 300
        if (amount <= 0 || amount > balance) 
        {
            Console.WriteLine("Invalid withdrawal!");
            return;
        }

        balance -= amount;  // storing/updateing the balance  
        Console.WriteLine($"Withdrawn: ₹{amount}");
    }

    // Display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: ₹{Balance}");
        Console.WriteLine("--------------------------------");
    }

    // Abstract method
    public abstract decimal CalculateMonthlyBenefit();

   
}




// ======================================================
// CONCEPT 7: INTERFACES
// Interfaces define a contract that implementing classes must follow.
// ======================================================

public interface IAccount
{
   void Deposit(decimal amount); //return nothing
    void Withdraw(decimal amount); //signatures
}
