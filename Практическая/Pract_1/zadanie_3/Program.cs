using zadanie_3;

Random rand = new Random();

Person person1 = new Person() { FIO = "Иванов Иван Иванович", Position = "Управляющий" };
Person person2 = new Person() { FIO = "Дмитриев Дмитрий Дмитриевич", Position = "Сотрудник" };
Person person3 = new Person() { FIO = "Сергеев Сергей Сергеевич", Position = "Сотрудник" };

List<Person> people = new List<Person>() { person1, person2, person3 };

ControlBuildings CB = new ControlBuildings();

for (int i = 0; i < rand.Next(20, 100); i++)
{
    Building building = new Building() { Address = $"Lenina street {rand.Next(1, 300)}", AmortizationPeriod = rand.Next(-10, 10), Cost = rand.Next(100000, 50000000), InventoryNumber = i };
    CB.AllBuildings.Add(building);
    people[i % people.Count].List_Buildings.Add(building);
}

Console.WriteLine($"Все поставленные на учёт здания:\n");
foreach (Building building in CB.AllBuildings)
{
    Console.WriteLine($"Inventory Number: {building.InventoryNumber} \tAdress: {building.Address} \tAmortization Period: {building.AmortizationPeriod} \tCost: {building.Cost}");
}

Building MostExpensiveBuilding = CB.FindMostExpensive(CB.AllBuildings);
Console.WriteLine($"Самое дорогое здание на учёте: \n ");
Console.WriteLine($"Inventory Number: {MostExpensiveBuilding.InventoryNumber} \tAdress: {MostExpensiveBuilding.Address} \tAmortization Period: {MostExpensiveBuilding.AmortizationPeriod} \tCost: {MostExpensiveBuilding.Cost} \n\n");

List<Building> OverdueBuildings = CB.FindOverdue(CB.AllBuildings);
Console.WriteLine($"Здания у котороых закончился срок амортизации: \n");
foreach (Building building in OverdueBuildings)
{
    Console.WriteLine($"Inventory Number: {building.InventoryNumber} \tAdress: {building.Address} \tAmortization Period: {building.AmortizationPeriod} \tCost: {building.Cost}");
}