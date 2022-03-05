using LabWork2;
using LabWork2.Interfaces;
using LabWork2.Food.HealthyFood;
using LabWork2.Food.SemiFinishedFood;
using LabWork2.Food.Snacks;
using LabWork2.NotFood;

U_Market UM = new();

// Объявлнение всех товаров магазина
List<IThing> HealthyFood  = new() { new Chicken() { Name = "Кулебяка" }, new Fruit() { Name = "Яблоко" }, new Fruit() { Name = "Банан" }, new OliveOil() { Name = "Афинская радость" }};
HealthyFood.ForEach(food => UM.Things.Add(food));

List<IThing> SFF = new() { new Cheburek() { Name = "Чебурек" }, new DumplingsBerries() { Name = "Пирожок" }, new DumplingsMeat() { Name = "Фарш" } };
SFF.ForEach(food => UM.Things.Add(food));

List <IThing> Snacks = new() { new BalykCheese() { Name = "Сыр Балык" }, new BalykCheese() { Name = "Сыр Балык 2" },  new ChocolateBar() { Name = "Шоколад Альпийская радость" }, new ChocolateBar() { Name = "Шоколад Milky Way" }, new Crisps() { Name = "Lay's"}, new Crisps() { Name = "Русская Картошка" } };
Snacks.ForEach(food => UM.Things.Add(food));

List<IThing> NotFood = new() { new Pen() { Name = "Ручка"}, new Pen() { Name = "Ручка 2"}, new Notebook() { Name = "Блакнот"}, new Notebook() { Name = "Тетрадь"} };
NotFood.ForEach(thing => UM.Things.Add(thing));

Console.WriteLine(UM.NicePrintEverything());

// Основной цикл программы
while (true)
{
    Console.WriteLine("\nHere what u can do:\n\n 1 - Add Product to the cart\n 2 - Delete Product from the cart\n 3 - Choose a filter \n 4 - See what is in ur cart\n 5 - Balanse my cart\n");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Print product's id: ");
            if (!Int32.TryParse(Console.ReadLine(), out int add_id))
            {
                Console.WriteLine("Некорректный ввод...: ");
                continue;
            }
            try
            {
                UM.cart.FoodStuffs.Add((IFood)UM.Things[add_id]);
                Console.WriteLine(UM.cart.PrintCart());
                continue;
            }
            catch (Exception) { Console.WriteLine("Не удалось добавить этот продукт"); continue;  }
        case "2":
            Console.WriteLine("Print product's id: ");
            if (!Int32.TryParse(Console.ReadLine(), out int del_id))
            {
                Console.WriteLine("Некорректный ввод...: ");
                continue;
            }
            try
            {
                UM.cart.FoodStuffs.Remove((IFood)UM.Things[del_id]);
                Console.WriteLine(UM.cart.PrintCart());
                continue;
            }
            catch (Exception) { Console.WriteLine("Не удалось удалить этот продукт"); continue; }
        case "3":
            Console.WriteLine("\n 1 - All categories\n 2 - Healthy Food\n 3 - SemiFinished Food\n 4 - Snacks\n");
            string[] cases = new string[] { "1", "2", "3", "4" };
            string filter = Console.ReadLine() ?? "1";
            if (cases.Contains(filter)) { Console.WriteLine(UM.NicePrintCategory(filter)); UM.cart.Filter = filter;}
            else Console.WriteLine("Такой опции, увы, нет...");
            continue;
        case "4":
            Console.WriteLine(UM.cart.PrintCart());
            continue;
        case "5":
            List<IFood> AllFood = new();
            UM.Things.ForEach(food => { if (food is IFood food1) AllFood.Add(food1); });
            Console.WriteLine(UM.cart.CartBalancing(AllFood));
            Console.WriteLine(UM.cart.PrintCart());
            continue;
        default:
            continue;
    }
}
