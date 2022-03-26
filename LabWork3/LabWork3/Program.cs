using LabWork3;
using LabWork3.Extensions;

VideoconfIS cideoconfIS = new();
List<string> AllServices = cideoconfIS.GetAllServices();

// Greetings
Console.WriteLine($"" +
    $"\t{string.Concat(Enumerable.Repeat("-", 18))}\n\t" +
    $"{string.Concat(Enumerable.Repeat("=", 5))}" +
    $"Welcome!" +
    $"{string.Concat(Enumerable.Repeat("=", 5))}\n" +
    $"\t{string.Concat(Enumerable.Repeat("-", 18))}");

void ConsolePrintTeachers()
{
    Console.WriteLine($"" +
        $"{string.Concat(Enumerable.Repeat("=", 5))}" +
        $"Преподаватели" +
        $"{string.Concat(Enumerable.Repeat("=", 5))}");
    cideoconfIS.Teachers.ForEach(teacher =>
    {
        Console.Write($"{cideoconfIS.Teachers.IndexOf(teacher)} - {teacher.Print()} \t " +
        $"{teacher.Institute} \t");
        ColorPrintService(teacher.VideoConfService);
        Console.WriteLine();
    });
    Console.WriteLine($"{string.Concat(Enumerable.Repeat("-", 21))}\n");
}

void ConsolePrintTop()
{
    Console.WriteLine($"" +
        $"{string.Concat(Enumerable.Repeat("=", 3))}" +
        $"Топ 3 любимых сервиса" +
        $"{string.Concat(Enumerable.Repeat("=", 3))}");
    int place = 0;
    cideoconfIS.TOP().ForEach(service =>
    {
        place++;
        System.Console.Write($"{place} - ");
        ColorPrintService(service.Name);
        System.Console.WriteLine($" \t\t Количество использований: {service.NumberOfUsage}");
    });
    Console.WriteLine($"{string.Concat(Enumerable.Repeat("-", 21))}\n");
}

void ConsolePrintMenu()
{
    Console.WriteLine("\nA - добавить преподавателя\nEscape - Выход",
        Console.BackgroundColor = ConsoleColor.White,
        Console.ForegroundColor = ConsoleColor.Black);
}

void ColorPrintService(string service)
{
    if (AllServices.Contains(service))
    {
        const int MAX_LENGTH_COLORS = 14;
        Console.Write($"[{service}]",
        Console.ForegroundColor = (ConsoleColor)((AllServices.IndexOf(service) + 1) % MAX_LENGTH_COLORS));
        Console.ResetColor();
    }
    else return;
}

while (true)
{
    AllServices = cideoconfIS.GetAllServices();
    Console.ResetColor();
    // Преподаватели
    ConsolePrintTeachers();

    // Топ 3 любимых сервиса
    ConsolePrintTop();

    // Меню
    ConsolePrintMenu();
    Console.ResetColor();

    while (true)
    {
        var key = Console.ReadKey().Key;
        if (key == ConsoleKey.Escape) System.Diagnostics.Process.GetCurrentProcess().Kill();
        if (key == ConsoleKey.A)
        {
            Console.WriteLine("\nВведите ФИО преподавателя\n");
            string FIO = Console.ReadLine();

            // Проверка правильности ввода
            if (FIO is null)
            {
                Console.WriteLine("\nФИО задано в неверном формате\n");
                break;
            }
            string[] FIOArray = FIO.Split(' ');
            if (FIOArray.Length != 3)
            {
                Console.WriteLine("\nФИО задано в неверном формате\n");
                break;
            }

            Console.WriteLine("\nВведите институт преподавателя\n");
            string Institute = Console.ReadLine();
            if (Institute is null)
            {
                Console.WriteLine("\nИнститут задан в неверном формате\n");
                break;
            }

            Console.WriteLine("\nВведите видеосервис преподавателя\n");
            string VideoConfService = Console.ReadLine();
            if (VideoConfService is null)
            {
                Console.WriteLine("\nВидеосервис задан в неверном формате\n");
                break;
            }

            Console.WriteLine(
                cideoconfIS.AddTeacher(new Teacher()
                {
                    FIO = FIO,
                    Institute = Institute,
                    VideoConfService = VideoConfService
                }),
                Console.BackgroundColor = ConsoleColor.White,
                Console.ForegroundColor = ConsoleColor.Black);
            break;
        }
    }
}
