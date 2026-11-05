// //class structure --oops

// //modifiers 
// public class BankAcc
// {
//     public decimal balance{get; set;} //property
//     public void print() //method action
//     {
//         Console.WriteLine("test print");
//     }
// }

// //var acc = new BankAcc(); //new keyword means object--->

// //adding constructor 
// public class AnotherBankAcc
// {
//     public decimal balance{get; set;}

//     public AnotherBankAcc(decimal amount)
//     {        
//     }
//     public void print()
//     {
//         Console.WriteLine("test print");
//     }
// }

// // var acc = new AnotherBankAcc(10);

// //encapsulation 
// //public,
// public class EncapBankAcc
// {
//     private decimal balance{get; set;} ///acess thhis propety
//     public EncapBankAcc(decimal amount)
//     {        
//     }
//     public void print()
//     {
//         Console.WriteLine("test print");
//     }
// }

// //polymorphism -->method overloading + method overriding

// public class OverloadBankAcc
// {
//     private decimal balance{get; set;} ///acess thhis propety
//     public OverloadBankAcc(decimal amount)
//     {        
//     }
//     public void print()
//     {
//         Console.WriteLine("test print");
//     }    
//     public void print(string name) // 1 param 
//     {
//         Console.WriteLine("test print");
//     }   
//     public void print(decimal amount)  // 1 param + different datatype ==>method overloading
//     {
//         Console.WriteLine("test print");
//     }
//     public void print(string name, string amount) 
//     {
//         Console.WriteLine("test print");
//     }    
//     public void print(string name, decimal amount, bool isvalid) 
//     {
//         Console.WriteLine("test print");
//     }

// }
// //overriding ==> refers to methods
// public class OverRideBankAcc
// {
//     private decimal balance{get; set;} ///acess thhis propety
//     // public OverRideBankAcc(decimal amount) //constructor
//     // {        
//     // }
//     public void print() //method
//     {
//         Console.WriteLine("test print");
//     }  
//     public virtual void printStatement(string name) //method
//     {
//        // Console.WriteLine("test print statement"); //default
//     }
// }

// //inheritance -- > allows one class to use properties + methods of another class  :
// public class ChildOverRideBankAcc : OverRideBankAcc
// {   
//     public override void printStatement(string name)
//     {
//         //base.printStatement(name);
//        // Console.WriteLine("i can modify this implementation according to my needs");
       
//     }
// }
// // var acc =new ChildOverRideBankAcc();
// // acc.print(); 
// // acc.printStatement("john");

// //abstraction--->refers to the common functionality having all the required properties + functions .. u can refer it as an base class
// public abstract class AbsBankAccount
// {
//     private decimal balance{get; set;} ///acess thhis propety
//     public string name {get; set;}
//     public string loannumber {get; set;}
//     public string loaninterest {get; set;}
   
//     public void print() //method
//     {
//         Console.WriteLine("test print");
//     }  
//     public abstract void printStatement(string name); //method
    
// }
// public class AccountDept : AbsBankAccount
// {

//     public override void printStatement(string name)
//     {
//         Console.WriteLine(name);        
//     }
// }

// // var acc = new AccountDept();
// // acc.printStatement("gopi")

// //interface ---> represents an contract which must be implemented by any class whoever wanted to use this interface
// public interface IBank
// {   
//     public void Deposit(); //declaration
//     public void Withdraw();
// }

// public class RegularAccount : IBank
// {
//     public void Deposit()
//     {
//         Console.WriteLine("Deposited"); //implementation
//     }
//     public void Withdraw()
//     {
//         Console.WriteLine("withdrawal");
//     }
// }
// var acc = new RegularAccount();
// acc.Deposit(); //accessing the functions
// acc.Withdraw();


