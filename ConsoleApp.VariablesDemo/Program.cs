// See https://aka.ms/new-console-template for more information

// Different Datatypes

/*
 * text - string    
 * integeres - int
 * decimal - double, float, decimal (increasing precision )
 * logical - bool 
*/


// datatype variable name = variable value (always used like this)

// string
string name = "Metereya Singh Rawat";

Console.WriteLine(name);  // using variable
Console.WriteLine("My name is Metereya Singh Rawat"); // static code


Console.WriteLine("My name is " + name); // concatenating the stirng
Console.WriteLine($"They call me {name} "); // string interpolation
Console.WriteLine("I am known as them {0}", name); // string formating


// integer

int age = 18; // age, my_age and My_age all point to different variables
int retirement_years_left = 47;
int retirement_age = age + retirement_years_left;

Console.WriteLine(age);
Console.WriteLine("My age is > " + age);
Console.WriteLine("My retirement is > " + retirement_age);

// boolean

bool isRetired = false;

Console.WriteLine("Is he retired? " + isRetired);
