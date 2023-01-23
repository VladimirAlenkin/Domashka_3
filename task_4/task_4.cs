Console.WriteLine("Задача 4: показать кубы чисел, заканчивающихся на четную цифру");
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число M, больше, чем N");
int M = int.Parse(Console.ReadLine()!);
int result = 1;
int remains = 0;
while ( N <= M )
{
result = N * N * N;
remains = result % 2; 
if (remains == 0 )
{
    Console.WriteLine("Число - "  + N + " в кубе - чётное: " + result);
}
N = N + 1;
}

