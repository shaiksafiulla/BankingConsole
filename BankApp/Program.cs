using BankApp;
using System.Threading.Tasks;

#region comments 
  
//   int amount = 10;
//   Console.WriteLine(amount);

// string fruit= "Apple";
//  Console.WriteLine(fruit);

//ctrl + K/C --- comments



#endregion

#region  variables

// string name ="JOhn"; //assigning the values
// int age = 27; //assigning the values
// Console.WriteLine($"{name} is {age} years"); //reading the values

#endregion

#region  constants
// const double pi = 3.14; // assinging happens only once at the global level of the application.. and cannot be re-assinged
// Console.WriteLine(pi);
#endregion

#region  DataTypes and conversions
// int, decimal, long, bool, float, object, string ,char etc // datatpes
// int amount= 10; //10; 10.09
// decimal balance = 98.007m;
// bool isactive = true; //true/ false
// char grade = 'A'; //one character
// string name = "john"; //  " " single/multi character

//-----------------------------//

// var message = "hello"; //string value --dynamic representation
// var total = 25;  //int value
// Console.WriteLine(message + total);

//nullable

// int? optionalAge = null;
// Console.WriteLine(optionalAge ?? 0);

// string? name = "john"; //"john" null
// Console.WriteLine(name);


//parsing 

// string input = "245"; //"25"
// int number = int.Parse(input); //parse
// // Console.WriteLine("string : " + input  + "number : " + number);

// //conversions


// bool sucess = int.TryParse("xyz", out int result); //true/false 
// //success returns whether the expression is valid or not... 
// Console.WriteLine(sucess); 


//interpolation
//  string item = "keyboard";
//  decimal cost = 460.50m;
//  Console.WriteLine($"Item : {item}, cost : {cost}"); //placeholders denote with $ sign... 


 


#endregion


#region  operators

//arthimetic operators
 
//   int a=10, b= 3;
//  Console.WriteLine(a + b); //sum
//   Console.WriteLine(a / b); //division
//   Console.WriteLine(a * b);
//     Console.WriteLine(a % b); //reminders


    //compare operators
//     int age=20;
// Console.WriteLine(age >= 18); //does 20 is less than or equal to 18
// Console.WriteLine(age == 18); //does 20 is  equal to 18

//logical operators


//person==adult/kid holding and id pass 

// bool hasId = true;    //true/false
// bool isAdult = false; //person is an kid
// Console.WriteLine(hasId && isAdult); //"&&" checking the AND condition
// Console.WriteLine(hasId || isAdult); // "||" checking the OR condition
// Console.WriteLine(!hasId); // "!" if NOT  do we had idpass


//Assignment and increment

// int count = 5; //assingment
// count += 2; // 5 + 2 = 7 .. update with the previous value; + refers to addion. - refers to subtraction
// count -= 2; // 7 - 2 = 5 .. 
// count ++; // increment by one number
// count--; // decrement by one number

// Console.WriteLine(count);




#endregion

#region Decision Making and Loops
// if/else
//  int marks = 70;
//  if(marks > 70) // putting some condition
// {
//     Console.WriteLine("Pass");    
// }
// else
// {
//      Console.WriteLine("fail");    
// }
// //switch
// int day =5; //expression  Friday
// switch (day)
// {
//     case 1 : Console.WriteLine("Monday");   break; //
//     case 2 : Console.WriteLine("Tuesday");  break; //
//     default : Console.WriteLine(DayOfWeek.Friday);  break;
// }

//for loop
// for (int i =1; i <= 10; i++) //iterating ..we are fixing the size
// {
//     Console.WriteLine("i");
// }

//while loop
// int i= 1;
// while (i <= 5) //we are fixing the size
// {
//     Console.WriteLine("i");
//     i++; //increments by one
// }

//foreach loop
// string[] names = {"john", "Dave", "Rao"}; //array 
// foreach(string name in names) //whatever the length of the array it is
// {
//     Console.WriteLine(name);
// }

#endregion

#region  METHODS
// static void Greet()  //function/method..void means nothing to return and prints something
// {
//     Console.WriteLine("welcome");
// }
// Greet();

//parameters and retunr values
// static int Add(int x, int y)  //function/method..void means nothing to return and prints something
// {
//     return x+y; //(4+6=10)
   
// }
// Console.WriteLine(Add(14,6));

//method overloading
// static int Add(int x, int y) => x + y;
// static int Addition(int x, int y, int c) => x + y +c ;
// // static double Add(double a, double b, double c) => a + b +c;
// Console.WriteLine(Add(14,6));
// Console.WriteLine(Addition(2, 3, 4));

//arrays
// int[] numbers ={10,20,30,40};  //refers to the rack containers
// Console.WriteLine(numbers[0]); //printing the first item by index = 0;
// Console.WriteLine(numbers.Length); //

//list
// var names =new List<string> {"ram","john","babel"}; // LISTS,COLLECTIONS
// names.Add("rao"); //APPENDING
// names.Remove("babel"); //REMOVING
// foreach(var name in names)
// {
//     Console.WriteLine(name);
// }

//dictionary == key==>value pairs ... inferring ==> deriving something out of the context
// var prices =new Dictionary<string, decimal>
// {
//     ["pen"] = 10m, //decimal
//     ["book"] = 50m
// };
// Console.WriteLine(prices["book"]);


//hashset

// var ids = new HashSet<int> {1,2,2,3,3,4,5,5}; //stores unique items and is usefule whenever we should remove the duplicates
// Console.WriteLine(ids.Count);

// sorting array
// int[] values = {5,1,9,3,7};
// Array.Sort(values); //rea-aligning the number in ascending order.. 1,3,5,7,9
// Console.Write(values[4]); //first index of the array
// // Console.Write(Array.IndexOf(values,5));


// class and object
//instance of the class refers to object
// var car =new Car(); //generate an real time thing out of the class===> object...new keyword refers to creation of the object
// Console.WriteLine(car.brand);
// car.start();
// car.Specifications();







#endregion

public class Program
{
    public static async Task Main(string[] args) //main entry function
    {
        // Console.WriteLine("==================================");
        // Console.WriteLine("       BANK APPLICATION");
        // Console.WriteLine("       C# OOP CONCEPTS");
        // Console.WriteLine("==================================");


        // // ==========================================
        // // CONCEPT 1: CLASSES AND OBJECTS
        // // ==========================================

        // Console.WriteLine("\n1. CLASSES AND OBJECTS");
        // //father level
        // BankAccount rahulAccount =
        //     new BankAccount("SB1001", "Rahul", 5000m);

        // rahulAccount.DisplayAccountDetails();


        // // ==========================================
        // // CONCEPT 2: ENCAPSULATION
        // // ==========================================

        // Console.WriteLine("\n2. ENCAPSULATION");

        // rahulAccount.Deposit(2000m);
        // rahulAccount.Withdraw(1000m);

        // Console.WriteLine(
        //     $"Available Balance: ₹{rahulAccount.Balance}");

        // // Not allowed:
        // // rahulAccount.Balance = 50000;


        // // ==========================================
        // // CONCEPT 3: INHERITANCE
        // // ==========================================

        // Console.WriteLine("\n3. INHERITANCE");

        // SavingsAccount savingsAccount =
        //     new SavingsAccount("SB1002", "Priya", 10000m, 5m);

        // savingsAccount.DisplayAccountDetails();
        // savingsAccount.Deposit(2000m);

        // CurrentAccount currentAccount =
        //     new CurrentAccount(
        //         "CB1001", "Arun", 50000m, "ABC Technologies");

        // currentAccount.DisplayAccountDetails();

        // Console.WriteLine(
        //     $"Business Name: {currentAccount.BusinessName}");


        // // ==========================================
        // // CONCEPT 4: POLYMORPHISM
        // // ==========================================

        // Console.WriteLine("\n4. POLYMORPHISM");

        // BankAccount account;

        // account = savingsAccount;

        // Console.WriteLine(
        //     $"Savings Account Charge: ₹{account.CalculateMonthlyCharge()}");

        // account = currentAccount;

        // Console.WriteLine(
        //     $"Current Account Charge: ₹{account.CalculateMonthlyCharge()}");


        // // ==========================================
        // // CONCEPT 5: OVERLOADING AND OVERRIDING
        // // ==========================================

        // Console.WriteLine("\n5. OVERLOADING AND OVERRIDING");

        // // Method overloading: First version
        // rahulAccount.Deposit(500m);

        // // Method overloading: Second version
        // rahulAccount.Deposit(1000m, "Salary Credit");

        // // Method overriding is demonstrated above
        // // through CalculateMonthlyCharge().


        // // ==========================================
        // // CONCEPT 6: ABSTRACT CLASSES
        // // ==========================================

        // Console.WriteLine("\n6. ABSTRACT CLASSES");

        // AbstractBankAccount abstractAccount = savingsAccount;

        // Console.WriteLine(
        //     $"Monthly Benefit: ₹{abstractAccount.CalculateMonthlyBenefit()}");

        // // Not allowed:
        // // AbstractBankAccount account = new AbstractBankAccount();


        // // ==========================================
        // // CONCEPT 7: INTERFACES
        // // ==========================================

        // Console.WriteLine("\n7. INTERFACES");

        // IAccount accountService = new BankAccount(
        //     "SB1003", "John", 4000m);

        // accountService.Deposit(1000m);
        // accountService.Withdraw(500m);  

        // Console.WriteLine("\n==================================");
        // // Console.WriteLine(" ALL OOPS CONCEPTS DEMONSTRATED");
        // Console.WriteLine("==================================");



        // SECTION 8: MODERN C# CONCEPTS

        ModernCSharpDemo modernCSharp = new ModernCSharpDemo();
        //modernCSharp.Run();
        await modernCSharp.RunAsync();

        // SOLID Principles
       // SolidPrinciples.Demonstrate();

        // Design Patterns
       // DesignPatterns.Demonstrate();

    }
}