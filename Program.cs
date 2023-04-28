void FillArray2(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    if (array.Length == 0) Console.Write("[ ]");
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
        Console.Write($"{array[array.Length - 1]}]");
    }
}

Console.WriteLine("Введите размер вашего массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];
Console.WriteLine("Вводите элементы вашего массива через Enter");
for (int i = 0; i < n; i++)
{
    array1[i] = Console.ReadLine();
}
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3) count++;
}
string[] array2 = new string[count];
FillArray2(array1, array2);
PrintArray(array2);
