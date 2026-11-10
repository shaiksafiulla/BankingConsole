namespace BankApp;

// SOLID principles: five guidelines for writing maintainable, flexible code.
public static class SolidPrinciples
{
    public static void Demonstrate()
    {
        // 1. SRP: one class has one responsibility.
        new StatementPrinter().Print("Deposit of 500 completed.");

        // 2. OCP: add new interest calculators without changing the service.
        IInterestCalculator calculator = new SavingsInterestCalculator();
        Console.WriteLine($"Interest: {calculator.Calculate(1000m):C}");

        // 3. LSP: a derived account can be used wherever its base type is expected.
        WithdrawableAccount account = new SavingsWithdrawableAccount(500m);
        account.Withdraw(100m);
        Console.WriteLine($"Remaining balance: {account.Balance:C}");

        // 4. ISP: a class implements only the small contract it needs.
        IBalanceReader readOnlyAccount = new BalanceOnlyAccount(750m);
        Console.WriteLine($"Read-only balance: {readOnlyAccount.GetBalance():C}");

        // 5. DIP: the service depends on an interface, not a concrete logger.
        var transferService = new BankTransferService(new ConsoleTransactionLogger());
        transferService.Transfer(100m);
    }
}

// SRP
public class StatementPrinter
{
    public void Print(string message) => Console.WriteLine(message);
}

// OCP
public interface IInterestCalculator
{
    decimal Calculate(decimal principal);
}

public class SavingsInterestCalculator : IInterestCalculator
{
    public decimal Calculate(decimal principal) => principal * 0.05m;
}

// LSP
public abstract class WithdrawableAccount
{
    public decimal Balance { get; private set; }

    protected WithdrawableAccount(decimal openingBalance) => Balance = openingBalance;

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
            throw new ArgumentException("Invalid withdrawal amount.");

        Balance -= amount;
    }
}

public class SavingsWithdrawableAccount : WithdrawableAccount
{
    public SavingsWithdrawableAccount(decimal openingBalance) : base(openingBalance) { }
}

// ISP
public interface IBalanceReader
{
    decimal GetBalance();
}

public class BalanceOnlyAccount : IBalanceReader
{
    private readonly decimal _balance;

    public BalanceOnlyAccount(decimal balance) => _balance = balance;

    public decimal GetBalance() => _balance;
}

// DIP
public interface ITransactionLogger
{
    void Log(string message);
}

public class ConsoleTransactionLogger : ITransactionLogger
{
    public void Log(string message) => Console.WriteLine(message);
}

public class BankTransferService
{
    private readonly ITransactionLogger _logger;

    public BankTransferService(ITransactionLogger logger) => _logger = logger;

    public void Transfer(decimal amount)
    {
        _logger.Log($"Transfer of {amount:C} completed.");
    }
}
