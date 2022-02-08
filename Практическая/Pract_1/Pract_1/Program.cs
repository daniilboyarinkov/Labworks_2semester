// Задание 1
Console.WriteLine("Print a and b: ");



while (true)
{
    if (Int32.TryParse(Console.ReadLine(), out int a))
    {
        if (Int32.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine($"a: {a}, b: {b}");

            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine($"a: {a}, b: {b}");
            break;
        }
        else Console.WriteLine("Введите b как  число...: ");
    }
    else Console.WriteLine("Введите a как число...: ");
}
