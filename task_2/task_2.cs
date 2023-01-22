Console.WriteLine("Задача 2: подсчитать сумму цифр в числе");
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
int amount = 0;

while ( N/10 >= 1 )
{
amount = amount + N%10;
N = N/10;
}
amount = amount + N;
Console.WriteLine("Cумма цифр в числе - "  + amount );
