
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

int count = 5; //assingment
count += 2; // 5 + 2 = 7 .. update with the previous value; + refers to addion. - refers to subtraction
count -= 2; // 7 - 2 = 5 .. 
count ++; // increment by one number
count--; // decrement by one number

Console.WriteLine(count);




#endregion