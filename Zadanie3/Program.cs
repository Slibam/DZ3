//Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
int size = 8;
Random rand = new Random();
int[] numbers = new int[size];

for (int i = 0; i < size; i++)
{
    numbers[i]=rand.Next(-100, 101);
}

Console.WriteLine("Дан массив");
Console.Write("[");
for (int i = 0; i < size; i++)
{
    Console.Write($"{numbers[i]}, ");
}
Console.WriteLine("]");

int temp;
for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (Math.Abs(numbers[i]) > Math.Abs(numbers[j]))
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
Console.WriteLine( );
Console.WriteLine("Вывод отсортированного массива");
Console.Write("[");
for (int i = 0; i < size; i++)
{
    Console.Write($"{numbers[i]}, ");
}
Console.Write("]");






















/*Random rand = new Random();
int n1 = rand.Next(-100, 101);
int n2 = rand.Next(-100, 101);
int n3 = rand.Next(-100, 101);
int n4 = rand.Next(-100, 101);
int n5 = rand.Next(-100, 101);
int n6 = rand.Next(-100, 101);
int n7 = rand.Next(-100, 101);
int n8 = rand.Next(-100, 101);
int[] numbers = {n1, n2,n3, n4, n5, n6, n7, n8};
Console.WriteLine($"[{n1}, {n2},{n3}, {n4}, {n5}, {n6}, {n7}, {n8}]");
int temp;
for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (Math.Abs(numbers[i]) > Math.Abs(numbers[j]))
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
Console.WriteLine("Вывод отсортированного массива");
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}, ");
}
   Console.Write("]");*/