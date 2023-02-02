/* 14. С клавиатуры вводятся два числа a и b. 
Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
*/
Console.WriteLine("Привет! Данная программа проверяет число a на кратность числу b");
Console.WriteLine("Введите число a: ");
double a,b,multiplicity;
a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b: ");
b=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Результат: ");
multiplicity=a%b;
if (multiplicity==0)
{
  Console.WriteLine($"{a} кратно {b}");
}
else if (multiplicity!=0)
{
  Console.WriteLine($"{a} не кратно {b}. Остаток от деления: {multiplicity:F3}");
}
else // профилактика от ошибок
{
  Console.WriteLine("Ошиюка. Что-то пошло не так.");
}