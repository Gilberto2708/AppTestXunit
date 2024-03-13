// See https://aka.ms/new-console-template for more information
using console;

Console.WriteLine("Ingrese un numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un numero2:");
int num2 = int.Parse(Console.ReadLine());

var calculator = new Calculator();
var result = calculator.Sum(num1, num2);
Console.WriteLine("El resultado es: " + result);




