// 13. Удалить вторую цифру целого числа введенного с клавиатуры.
Console.WriteLine("Привет! Данная программа удаляет вторую цифру из введенного числа");
Console.WriteLine("Укажите число: ");
string? num = Console.ReadLine();
if (num.Length>1)
{
  num=num.Remove(num.Length-2,1);
  Console.WriteLine($"Результат: {num}");
}
else
{
  Console.WriteLine("Ошибка. Число однозначное");
}

