using LabWork2.Interfaces;

namespace LabWork2
{
    public class U_Market
    {
        public Cart<IFood> cart = new();
        public List<IThing> Things { get; set; } = new();

        public string NicePrintEverything()
        {
            string result = String.Empty;
            List<IThing> HealthyFood = new();
            List<IThing> SFF = new();
            List<IThing> Snacks = new();
            List<IThing> Other = new();

            Things.ForEach(thing =>
            {
            if (thing is IHealthyFood) HealthyFood.Add(thing);
            else if (thing is ISemiFinishedFood) SFF.Add(thing);
            else if (thing is ISnacks) Snacks.Add(thing);
            else Other.Add(thing);
            });

            result += "\n\tВот, что сейчас есть в магазине: \n-----------------------------------------------\n";

            result += "\n\tКатегория: 'Здоровая еда'\n--------\n";
            HealthyFood.ForEach(thing => result += $"{Things.IndexOf(thing)}: {thing.Name}\n");

            result += "\n\tКатегория: 'Полуфабрикаты'\n--------\n";
            SFF.ForEach(thing => result += $"{Things.IndexOf(thing)}: {thing.Name}\n");

            result += "\n\tКатегория: 'Закуски'\n--------\n";
            Snacks.ForEach(thing => result += $"{Things.IndexOf(thing)}: {thing.Name}\n");

            result += "\n\tКатегория: 'Дргуое'\n--------\n";
            Other.ForEach(thing => result += $"{Things.IndexOf(thing)}: {thing.Name}\n");

            result += "\n---------------------------------------------- -\n";

            return result;
        }
        public string NicePrintCategory(string category)
        {
            string result = String.Empty;
            result += "\n\tВот, что сейчас есть в магазине: \n-----------------------------------------------\n";

            List<IThing> FilteredThings = new();

            switch (category)
            {
                case "1":
                    return NicePrintEverything();
                case "2":
                    result += "\n\tКатегория: 'Здоровая еда'\n--------\n";
                    FilteredThings = Things.FindAll(thing => thing is IHealthyFood);
                    break;
                case "3":
                    result += "\n\tКатегория: 'Полуфабрикаты'\n--------\n";
                    FilteredThings = Things.FindAll(thing => thing is ISemiFinishedFood);
                    break;
                case "4":
                    result += "\n\tКатегория: 'Закуски'\n--------\n";
                    FilteredThings = Things.FindAll(thing => thing is ISnacks);
                    break;
            }
            FilteredThings.ForEach(thing => result += $"{Things.IndexOf(thing)}: {thing.Name}\n");

            return result;
        }
    }
}
