// 1.	С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)

Console.Write("Введите число для возведения его в квадрат: ");
string? s;
s = Console.ReadLine();
int a;
a = Convert.ToInt32(s);
Console.Write("Ответ: ");
checked // проверка на соблюдение возможноного диапазоне
{
  Console.WriteLine(a * a); // первый вариант кода 
}
Console.Write("Проверка: ");
Console.WriteLine(Math.Pow(a, 2)); // второй вариант кода

