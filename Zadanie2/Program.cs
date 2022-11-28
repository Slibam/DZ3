//Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень вы хотите его возвести: ");
int B = Convert.ToInt32(Console.ReadLine());
int Result = A;
for (int i = 0; i < B; i++)
{
    Console.Write($"{A} * {Result} = ");
    Result = Result * A;
    Console.Write($"{Result}");
    Console.WriteLine();
}
Console.WriteLine("Результат");
Console.WriteLine($"{A}^{B} = {Result}");