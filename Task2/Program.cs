Console.WriteLine("Введите число");

bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if (!isParsedA || a <= 0)
{
    Console.WriteLine("Вы ввели не корректные данные");
}

int amountOfNumders = AmountOfNumders(a);
int AmountOfNumders(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
Console.WriteLine($"Сумма цифр в числе = {amountOfNumders}");
