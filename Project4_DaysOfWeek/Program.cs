// 4. По заданному с клавиатуры номеру дня недели вывести его название
Console.WriteLine("Привет! Это ПО по номеру дня недели выводит название этого дня");
Console.WriteLine("Введи номер дня недели (от 1 до 7)");
int day;
day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8) // Знаю, что можно попроще, но хотелось попробовать вариант посложнее "типичного".
{
  if (day == 1) 
  {
    Console.WriteLine("Сегодня понедельник");
  }
  else if (day == 2) 
  {
    Console.WriteLine("Сегодня вторник");
  }
  else if (day == 3) 
  {
    Console.WriteLine("Сегодня среда");
  }
  else if (day == 4) 
  {
    Console.WriteLine("Сегодня четверг");
  }
  else if (day == 5) 
  {
    Console.WriteLine("Сегодня пятница");
  }
  else if (day == 6) 
  {
    Console.WriteLine("Сегодня суббота");
  }
  else if (day == 7)
  {
    Console.WriteLine("Сегодня воскресенье");
  }
}
else
{
  Console.WriteLine("Ошибка. Введенное число не принадлежит диапазону чисел [1;7].");
}