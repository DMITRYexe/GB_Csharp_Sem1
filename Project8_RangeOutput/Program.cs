// 8. Вывести на экран числа от -N до N
Console.WriteLine("Привет! Данная программа выводит все целые числа из диапазона [-N;N]");
Console.Write("Задайте N: ");
int N,Nminus,i;
N = Convert.ToInt32(Console.ReadLine());
if (N>=0)
{
Nminus=N*(-1);
i=Nminus;
while (i!=N+1)
{
  Console.Write($"{i} ");
  i++;
}
}
else
{
  Nminus=N;
  N=N*(-1);
  i=N;
  while (i!=Nminus-1)
{
  Console.Write($"{i} ");
  i--;
}
}