// 12.С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа.
Console.WriteLine("Привет! Данное ПО выводит максимальную цифру в числе из диапазона [10;99]");
Console.WriteLine("Укажите число из диапазона [10;99]: ");
int a,f,s;
a=Convert.ToInt32(Console.ReadLine());
if (a>9 && a<100)
{
f=a/10;
s=a%10;
if (f>s)
{
Console.WriteLine($"Наибольшая цифра: {f}");
}
else if (s>f)
{
Console.WriteLine($"Наибольшая цифра: {s}");
}
else if (s==f)
{
Console.WriteLine($"Цифры в числе одинаковы");
}
else
{
  Console.WriteLine("Ошибка. Что-то пошло не так"); // просто "защита" от неопознаных ошибок
}
}
else
{
  Console.WriteLine("Ошибка. Число не соответсвует диапазону");
}