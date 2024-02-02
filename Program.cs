// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 




Console.WriteLine("\n" + new string('-', 50) + "\n");



// program that calculates the area of ​​a rectangle

var sideA = 1.1;
var sideB = 1.1;
var result = 1.1;

Console.WriteLine("Calculate the area of a rectangle!!");

Console.WriteLine("Insert value A: ");
sideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert value B: ");
sideB = Convert.ToDouble(Console.ReadLine());

result = sideA * sideB;
Console.WriteLine("\nSide A: " + sideA + "\tSide B: " + sideB + "\nThe area of reactangle is: " + result);