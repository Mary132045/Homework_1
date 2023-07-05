// Задача 6. Опредение четности введенного числа
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
    Console.WriteLine("Введенное число является четным");
}
else
{
    Console.WriteLine("Введенное число не является четным");
}