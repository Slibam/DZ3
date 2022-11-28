//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number > 0)
{
    int f = number % 10;
    result = result + f;
    number/=10;
}
Console.WriteLine();
Console.WriteLine($"Cумма цифр в числе: {result}");