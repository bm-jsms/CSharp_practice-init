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



Console.WriteLine("\n" + new string('-', 50) + "\n");



Console.WriteLine("Calculate the area of a Circle!!");

var radio = 1.1;
var resultCircle = 1.1;

const double Pi = 3.14;

// Pi * radio*radio
Console.WriteLine("Enter radio value:");
radio = Convert.ToDouble(Console.ReadLine());

resultCircle = Pi * radio * radio;

Console.WriteLine("the area of the circle is: " + resultCircle);



Console.WriteLine("\n" + new string('-', 50) + "\n");



// logical operators
/*
&& = and
|| = or
! = not
^ = xor => if both values are different, the result is true
*/

// bool value1 = true;
// bool value2 = false;
// bool value3 = true;

var (value1, value2, value3) = (true, false, true);

bool result1 = value1 && value2;
Console.WriteLine("value1 && value2: " + result1); // false

bool result2 = value1 || value2;
Console.WriteLine("value1 || value2: " + result2); // true

bool result3 = !value3;
Console.WriteLine("!value1: " + result3); // false

bool result4 = (value1 && value2) || value3;
Console.WriteLine("(value1 && value2) || value3: " + result4); // true

bool result5 = value1 ^ value2;
Console.WriteLine("value1 ^ value2: " + result5); // true



Console.WriteLine("\n" + new string('-', 50) + "\n");



// Relational Operators
/*
== equal
!= different
> greater than
< less than
>= greater than or equal
<= less than or equal
*/

var (number1, number2, number3) = (10, 2, 3);
Console.WriteLine("Values: " + number1 + " " + number2 + " " + number3);

bool rst1 = number1 == number2;
Console.WriteLine("number1 == number2: " + rst1); // false

bool rst2 = number1 != number2;
Console.WriteLine("number1 != number2: " + rst2); // true

bool rst3 = number1 > number3;
Console.WriteLine("number1 > number3: " + rst3); // true

bool rst4 = number1 < number3;
Console.WriteLine("number1 < number3: " + rst4); // false

bool rst5 = number1 >= number3;
Console.WriteLine("number1 >= number3: " + rst5); // true

bool rst6 = number1 <= number2;
Console.WriteLine("number1 <= number2: " + rst6); // false



Console.WriteLine("\n" + new string('-', 50) + "\n");



// strings

string name = "Josué";
int age = 19;
string country = "Perú";

var presentation = $"Hello, my name is {name}, I am {age} years old and I am from {country}";
Console.WriteLine(presentation);