/*С клавиатуры вводятся два вещественных числа. 
Проверять является ли одно из них квадратом второго (блок-схема)
*/
Console.WriteLine("Привет! Данное ПО проверяет не является ли одно число квадратом другого.");
Console.Write("Для старта введи первое число: ");
string? firstNum = Console.ReadLine();
double f;
checked
{
  f = Convert.ToDouble(firstNum);
}
Console.Write("Введите второе число: ");
string? SecondNum = Console.ReadLine();
double s;
checked
{
  s = Convert.ToDouble(SecondNum);
}
if (f * f == s)
{
  Console.WriteLine($"{s} является квадратом {f}.");
}
else if (s * s == f)
{
  Console.WriteLine($"{f} является квадратом {s}.");
}
else
{
  Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
