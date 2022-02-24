using zadanie_2;

List<Cadet> cadets = new List<Cadet> ();

while (true)
{
    Console.WriteLine("Print N: ");
    if (!Int32.TryParse(Console.ReadLine(), out int N))
    {
        Console.WriteLine("Введите число...");
        continue;
    }

    Random rand = new Random();
    for (int i = 0; i < N; i++)
    {
        cadets.Add(new Cadet() { pull_ups = rand.Next(1, 30) });
    }

    int count_3 = 0;
    int count_4 = 0;
    int count_5 = 0;

    int max_pull_ups = 0;
    int min_pull_ups = int.MaxValue;
    // нет это их порядковый номер грубо говоря да он двоечник

    foreach (Cadet cadet in cadets)
    {
        if (cadet.pull_ups >= 12 && cadet.pull_ups < 14) count_3++;
        if (cadet.pull_ups >= 14 && cadet.pull_ups < 16) count_4++;
        if (cadet.pull_ups >= 16) count_5++;

        if (cadet.pull_ups > max_pull_ups) max_pull_ups = cadet.pull_ups;
        if (cadet.pull_ups < min_pull_ups) min_pull_ups = cadet.pull_ups;
    }

    Console.WriteLine("\nВсе подтягивания кадетов: \n");
    for (int i = 0;i < cadets.Count; i++)
    {
        Console.WriteLine($"id: {i} \tpull-ups: {cadets[i].pull_ups}");
    }

    Console.WriteLine($"\n\n3: {count_3} \n4: {count_4}\n5: {count_5}\n\nmax: {max_pull_ups}\nmin:{min_pull_ups}");
    break;
}
