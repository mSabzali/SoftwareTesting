Console.WriteLine("------------------------");
Calculator calculator = new();

var sum = calculator.Sum(4, 5);
Console.WriteLine("Sum is : " + sum);

var time = DateTime.Now;

int first= 80; 
Console.WriteLine(first.PulseFourExtension());

var divide = calculator.Divide(5, 0);
Console.WriteLine("Sum is : " + divide);