//7. Выяснить является ли число чётным.
Console.WriteLine("Привет! Данное ПО делает проверку числа на четность.");
Console.WriteLine("Введите число: ");
int N;
N=Convert.ToInt32(Console.ReadLine());
bool odd=N%2==0;
if (odd==true)
{
  Console.WriteLine($"{N} является четным числом.");
}
else
{
  Console.WriteLine($"{N} является нечетным числом.");
}