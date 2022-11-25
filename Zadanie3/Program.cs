//Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
Random rand = new Random();
int n1 = rand.Next(-100, 101);
int n2 = rand.Next(-100, 101);
int n3 = rand.Next(-100, 101);
int n4 = rand.Next(-100, 101);
int n5 = rand.Next(-100, 101);
int n6 = rand.Next(-100, 101);
int n7 = rand.Next(-100, 101);
int n8 = rand.Next(-100, 101);
int[] nums = {n1, n2,n3, n4, n5, n6, n7, n8};
Console.WriteLine($"[{n1}, {n2},{n3}, {n4}, {n5}, {n6}, {n7}, {n8}]");
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
Console.WriteLine("Вывод отсортированного массива");
Console.Write("[");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]}, ");
}
   Console.Write("]");