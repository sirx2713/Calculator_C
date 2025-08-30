// See https://aka.ms/new-console-template for more information

//Calculator

//Pseudocode

//Input
//1. First Number
//2. Second Number

//Process
//Processing Items
//1. sum
//2. product
//3. difference
//4. division
//5. power

//Algorithm
//1. Enter First number
//2. Enter Second number
//3. Enter the math operator
//4. Display the answer

//Output
//1. The math operation of the first number and second number
//2. The answer from the math operation


//Getting user input
Console.Write("Enter first number: ");
var number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number: ");
var number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Math Operator: ");
var op = Console.ReadLine();

//Selection of Operator
if (op == "+")
{
    var result = number1 + number2;
    Console.WriteLine($"{number1} + {number2} = {result}");
}
else if (op == "-")
{
    var result = number1 - number2;
    Console.WriteLine($"{number1} - {number2} = {result}");
}
else if (op == "*")
{
    var result = number1 * number2;
    Console.WriteLine($"{number1} * {number2} = {result}");
}
else if (op == "/")
{
    var result = number1 / number2;
    Console.WriteLine($"{number1} / {number2} = {result}");
}
else if (op == "%")
{
    var result = number1 % number2;
    Console.WriteLine($"{number1} % {number2} = {result}");
}
else if (op == "^")
{
    var result = Math.Pow(number1, number2);
    Console.WriteLine($"{number1} ^ {number2} = {result}");
}
else
{
    Console.WriteLine("Invalid operation!");
}