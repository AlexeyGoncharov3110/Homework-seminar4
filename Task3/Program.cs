Console.WriteLine("Введите число для размера массива");

bool isParsedSize = int.TryParse(Console.ReadLine(), out int sizeArray);
if (!isParsedSize || sizeArray <= 0)
{
    Console.WriteLine("Вы ввели не корректные данные");
    return;
}
int[] array = new int[sizeArray];

Console.WriteLine("Введите числа массива");
for (int i = 0; i < sizeArray; i++)
{
    bool isParsedElement = int.TryParse(Console.ReadLine(), out int elementArray);
    if (!isParsedElement)
    {
        Console.WriteLine("Вы ввели не корректные данные");
        return;
    }
    array[i] = elementArray;
    
}
PrintArray(array);
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}