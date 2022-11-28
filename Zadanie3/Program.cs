//Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Zadanie3()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArrau(numbers);
    Console.WriteLine("Дан массив");
    Vivod(numbers);
    SortMass(numbers);
    Console.WriteLine();
    Console.WriteLine("Вывод отсортированного массива");
    Vivod(numbers);
}
void FillArrau(int[] nums)
{
    int size = nums.Length;
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-100, 101);
    }
}
void SortMass(int[] numbe)
{
    int temp;
    for (int i = 0; i < numbe.Length - 1; i++)
    {
        for (int j = i + 1; j < numbe.Length; j++)
        {
            if (Math.Abs(numbe[i]) > Math.Abs(numbe[j]))
            {
                temp = numbe[i];
                numbe[i] = numbe[j];
                numbe[j] = temp;
            }
        }
    }
}
void Vivod(int []nums)
{
    int size = nums.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{nums[i]}, ");
    }
    Console.WriteLine("]");
}
Zadanie3();























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