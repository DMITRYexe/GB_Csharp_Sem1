// С клавиатуры вводятся два числа a и b. Найти максимальное из них. 
Console.WriteLine("Привет! Это ПО ищет наибольшее число из двух.");
Console.Write("Введите первое число: ");
int a, b, max;
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
  max = a;
  Console.WriteLine($"Наибольшее число: {max}");
}
else if (b > a)
{
  max = b;
  Console.WriteLine($"Наибольшее число: {max}");
}
else Console.WriteLine("Числа равны");