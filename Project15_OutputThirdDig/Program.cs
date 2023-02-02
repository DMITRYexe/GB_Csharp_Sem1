/* С клавиатуры вводится целое число. 
Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
*/
Console.WriteLine("Привет! Эта программа выводит третью цифру из целого числа.");
Console.WriteLine("Укажите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i,answ;
if (num>99)
{
i=num/100;
answ=i%10;
Console.WriteLine($"Результат: {answ}");
}
else if (num<-99)
{
i=num/100;
answ=(i%10); // не стал переводить ответ в положительное число, т.к. считаю логичнее оставить ответ отрицательным
Console.WriteLine($"Результат: {answ}");
}
else
{
  Console.WriteLine("NO");
}
