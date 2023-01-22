Console.WriteLine("Задача 1: найти кубы чисел от 1 до N");
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
if (N < 1)
{
    Console.WriteLine("Введено некорректное число");
}
int count = 1;
while (count <= N)
{
    int result = count*count*count;
    Console.WriteLine("Число - " + count + "; куб числа - " + result);
    count = count + 1;
}