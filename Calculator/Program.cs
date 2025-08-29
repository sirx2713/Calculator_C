// See https://aka.ms/new-console-template for more information

//Calculator

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