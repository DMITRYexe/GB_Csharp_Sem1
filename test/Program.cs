    // 11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца.
    Console.WriteLine("Привет! Данная программа выводит вторую цифру в числах больше 9.");
    Console.WriteLine("Введите число: ");
    int i, n, count, n2, answ; // Вводим переменные
    n = 10;
    count = 1;
    i = Convert.ToInt32(Console.ReadLine());
    while (n < i) // Считаем сколько цифр в чилсе
    {
      n = n * 10;
      count = count + 1; // общее значение цифр
    }
    Console.WriteLine(count + "," + n + "," + i);
    count = count - 1;
    n2 = (int)Math.Pow(10, count);
    Console.WriteLine(count + "," + n2);
    do // Нам нужно найти второе число с конца. Значит нам нужно делить число до тех пор, пока оно не станет двухзначным
    {
      i = i % n2;
      count = count - 1;
      n2 = (int)Math.Pow(10, count);
    } while (i > 100);
    Console.WriteLine(count + "," + n2 + "," + i);
  string? ai = Console.ReadLine();
Console.WriteLine(ai.Remove(0,1));
