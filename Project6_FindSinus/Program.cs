// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math).  

Console.WriteLine("Привет! Эта программа ищет синус для определенного числа");
Console.Write("Введите число: ");
double a, y, x;
a = Convert.ToDouble(Console.ReadLine());
y = Math.Sin(a);
Console.WriteLine($"Если даны радианы, то sin = {y}");
x = a * Math.PI / 180;
y = Math.Sin(x);
Console.WriteLine($"Если даны градусы, то sin = {y}");


