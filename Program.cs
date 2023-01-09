// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// This is a comment
/* This is also a block comment
 * but multiline
 * this ends the comment
 */

//Below code I don't want to be active
//Console.WriteLine("I am active.");

//x is declared
int x;
//x is intialized
x = 10;

//combined
int y = 5;

//constant
const double TAXRATE = 0.06;
//TAXRATE = 1; you cannot change a constant

Console.WriteLine("Please enter a radius");
string result = Console.ReadLine();
double num = double.Parse(result);
//double num = double.Parse(Console.ReadLine));
double area = num * num * Math.PI;
Console.WriteLine(area);

//NULL
string myName = null;
Console.WriteLine(myName);
string friend = "Josh Carolin";

if (friend == "Family")
{
    myName = "Justin";
}
else if (friend == "Josh Carolin")
{
    myName = "Jeo";
}
Console.WriteLine(myName);
