// Задача 8. 
Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());
for(int i = 2; i < num; i += 2)
    if (i % 2 == 0)
    Console.Write(i + " ");
