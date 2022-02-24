// Задание 1
// 2 вариант

while (true)
{
    Console.WriteLine("Print a: ");
    if (!Int32.TryParse(Console.ReadLine(), out int a))
    {
        Console.WriteLine("Введите a как число...: ");
        continue;
        // переходит к сл итерации 
    }

    Console.WriteLine("Print b: ");
    if (!Int32.TryParse(Console.ReadLine(), out int b))
    {
        Console.WriteLine("Введите b как  число...: ");
        continue;
    }
    Console.WriteLine($"a: {a}, b: {b}");

    // Обмен местами значений a и b с помощью операции xor
    // да. хорошо
    a ^= b;
    b ^= a;
    a ^= b;

    Console.WriteLine($"a: {a}, b: {b}");
    break;
}
