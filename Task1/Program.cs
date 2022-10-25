Console.WriteLine("Введите два числа");

bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if (!isParsedA || !isParsedB || b <= 0)
{
    Console.WriteLine("Ошибка! Не правильно введены данные");
    return;
}
int numberDegree = NumberDegree(a, b);

int NumberDegree(int digit, int degree)
{
    int result = digit;
    for (int i = 1; i < degree; i++)
    {
        result *= digit;
    }
return result;
}

Console.WriteLine($"Число {a} в {b} степени равно {numberDegree}");
