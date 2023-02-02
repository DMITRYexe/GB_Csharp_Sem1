// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
Console.WriteLine("Привет! Это ПО выводит последнюю цифру введенного числа");
Console.WriteLine("Введите число: ");
int i=Convert.ToInt32(Console.ReadLine()); // Вводим число
int answ;
answ = i%10;
Console.Write($"Последняя цифра: {answ}");
