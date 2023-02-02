// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.WriteLine("Привет! Данное ПО находит максимальное число их трех.");
Console.Write("Введите первое число: ");
double a,b,c,max;
a=Convert.ToDouble(Console.ReadLine());
max = a;
Console.Write("Введите второе число: ");
b=Convert.ToDouble(Console.ReadLine());
if (b>a)
{
  max = b;
}
Console.Write("Введите третее число: ");
c=Convert.ToDouble(Console.ReadLine());
if (c>max)
{
  max = c;
}
if (c==a && b==a)
{
  Console.Write("Все числа одинаковы.");
}
else
{
  Console.Write($"Максимальное число: {max}");
}