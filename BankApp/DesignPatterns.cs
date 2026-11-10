namespace BankApp;

// Design patterns are reusable ways to organize code to solve common design problems.
// Learn them through three categories: object creation, object organization, and communication.

public static class DesignPatterns
{
    public static void Demonstrate()
    {
        Console.WriteLine("\n--- DESIGN PATTERNS ---");

        // 1. CREATIONAL: Create the required account based on the customer's choice.
        IBankAccountProduct account = BankAccountFactory.Create("savings");
        Console.WriteLine($"Created account: {account.AccountType}");

        // 2. STRUCTURAL: Use one common interface to work with different payment gateways.
        IPaymentGateway gateway = new BankPaymentGateway();
        gateway.Pay(500m);

        // 3. BEHAVIORAL: Notify subscribers when a transaction is completed.
        var transaction = new BankTransaction();
        transaction.TransactionCompleted += message => Console.WriteLine($"Notification: {message}");
        transaction.Complete("Deposit of 500 completed");
    }
}

// --------------------------------------------------
// 1. CREATIONAL PATTERNS – OBJECT CREATION
// Definition: These patterns help create objects while hiding the creation details.
// Banking example: Create a Savings Account or Current Account based on customer selection.
// --------------------------------------------------

public interface IBankAccountProduct
{
    string AccountType { get; }
}

public class SavingsAccountProduct : IBankAccountProduct
{
    public string AccountType => "Savings";
}

public class CurrentAccountProduct : IBankAccountProduct
{
    public string AccountType => "Current";
}

public static class BankAccountFactory
{
    public static IBankAccountProduct Create(string type)
    {
        return type.ToLower() switch
        {
            "savings" => new SavingsAccountProduct(),
            "current" => new CurrentAccountProduct(),
            _ => throw new ArgumentException("Unknown account type.")
        };
    }
}

// --------------------------------------------------
// 2. STRUCTURAL PATTERNS – OBJECT ORGANIZATION
// Definition: These patterns help organize classes and objects so they work together.
// Banking example: Use one common interface to connect to different payment gateways.
// --------------------------------------------------

public interface IPaymentGateway
{
    void Pay(decimal amount);
}

public class BankPaymentGateway : IPaymentGateway
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Payment of {amount:C} processed through the bank gateway.");
    }
}

// --------------------------------------------------
// 3. BEHAVIORAL PATTERNS – OBJECT COMMUNICATION
// Definition: These patterns define how objects communicate and coordinate their work.
// Banking example: Notify customers when a banking transaction is completed.
// --------------------------------------------------

public class BankTransaction
{
    // Event subscribers receive a notification when the transaction is completed.
    public event Action<string>? TransactionCompleted;

    public void Complete(string message)
    {
        TransactionCompleted?.Invoke(message);
    }
}
