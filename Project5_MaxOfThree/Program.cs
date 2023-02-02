// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.WriteLine("Привет! Данное ПО находит максимальное число их трех.");
Console.Write("Введите первое число: ");
int a,b,c,max;
a=Convert.ToInt32(Console.ReadLine());
max = a;
Console.Write("Введите второе число: ");
b=Convert.ToInt32(Console.ReadLine());
if (b>a)
{
  max = b;
}
Console.Write("Введите третее число: ");
c=Convert.ToInt32(Console.ReadLine());
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