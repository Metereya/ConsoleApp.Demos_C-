// Declare variables

using System.Xml;

string name = string.Empty; // creates an empty string >> ""
int age = 0;
int retirement_age = 65;

// prompt the user for input

Console.WriteLine("Please enter your name >>");
name = Console.ReadLine();
//Console.ReadLine(); 
// readline pauses the console and allows the user to enter input
// to store the variable we need to assign it to the container we want to use


// age = Console.Readline(); 
// however it stores the value as string
// for this we have the 'CONVERT' class to convert it

age = Convert.ToInt32(Console.ReadLine("Enter your age > "));

// process

int working_years = retirement_age - age;

// output

Console.WriteLine($"Full Name : {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years left: {working_years}");


