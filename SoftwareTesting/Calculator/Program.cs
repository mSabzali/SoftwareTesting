// See https://aka.ms/new-console-template for more information

Console.WriteLine("------------------------");
Calculator calculator = new();

var sum = calculator.Sum(4, 5);
Console.WriteLine("Sum is : " + sum);

var divide = calculator.Divide(5, 5);
Console.WriteLine("Sum is : " + divide);