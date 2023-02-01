// 9. Вывести на экран четные числа от 1 до N
Console.WriteLine("Привет! Это ПО выводит четные числа от 1 до N");
Console.WriteLine("Введи N, где N - целое число: ");
int i = 2, N;
N = Convert.ToInt32(Console.ReadLine());
if (N >= 2)
{
  while (i <= N)
  {
    Console.Write(i + " ");
    i = i + 2;
  }
}
else if (N < 2)
{
  i = 0; // Т.к. по условию отчет идет от 1, мы не должны учитывать двойку, если N отрицательно. 
while (i >= N)
  {
    Console.Write(i + " ");
    i = i - 2;
  }
}
else
{
  Console.Write("Ошибка при вводе N");
}