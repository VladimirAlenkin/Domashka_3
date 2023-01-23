Console.WriteLine("Задача 3: написать программу вычисления произведения чисел от 1 до N");
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
int B = 1;
for (int A = 2; A <= N; A++)
{
    B = B * A;
}
Console.WriteLine("Произведение чисел от 1 до "  + N +  " равно " + B );

