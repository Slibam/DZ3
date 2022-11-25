//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());
int digitIndex = 0;
double perv = number.ToString()[digitIndex] - '0';
digitIndex = 1;
double vtor = number.ToString()[digitIndex] - '0';
double tret = 0;
double xhet = 0;
double patoe = 0;
double itog = 0;
if (number >= 100)
{
    digitIndex = 2;
    tret = number.ToString()[digitIndex] - '0';
    if (number >= 1000)
    {
        digitIndex = 3;
        xhet = number.ToString()[digitIndex] - '0';
    
        if (number >= 10000)
        {
            digitIndex = 4;
            patoe = number.ToString()[digitIndex] - '0';
        }
    }
}
itog = perv + vtor + tret + xhet + patoe;
if (patoe != 0)
{
    Console.WriteLine($"({perv}+{vtor}+{tret}+{xhet}+{patoe}){itog}");
}
else if (xhet != 0)
{
        Console.WriteLine($"({perv}+{vtor}+{tret}+{xhet}){itog}");
}
else if (tret != 0)
{
        Console.WriteLine($"({perv}+{vtor}+{tret}){itog}");
}
else
{
        Console.WriteLine($"({perv}+{vtor}){itog}");
}