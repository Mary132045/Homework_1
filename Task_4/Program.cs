// Задача 4. Поиск максимального из трех введенных чисел.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    if(num1 > num3){
    Console.WriteLine("Первое число самое большое");
    }else{
    Console.WriteLine("Третье число самое большое");
}else
    if(num2 > num3){
    Console.WriteLine("Второе число самое большое");
    }else{
    Console.WriteLine("Третье число самое большое");
    }
