int[] CreateIntArray()
{
    Console.Write("Введите длину массива ");
    int line = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[] array = new int[line];
    return array;
}
int[] FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" " + array[i]);
    }
}
void Copy(int[] array)
{
    int[] array2 = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    Console.WriteLine();
    Console.Write("копия массива:");
    PrintArray(array2);
}
int[] numbers =CreateIntArray();
FillArray(numbers);
PrintArray(numbers);
Copy(numbers);

