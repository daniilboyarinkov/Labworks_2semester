namespace zadanie_3
{
    public class ControlBuildings
    {
        public List<Building> AllBuildings = new List<Building>(); 
        public Building FindMostExpensive(List<Building> buildings)
        {
            int max_cost = buildings[0].Cost;
            Building most_expensive_building = buildings[0];
            foreach (Building building in buildings)
            {
                if (building.Cost > max_cost)
                {
                    max_cost = building.Cost;
                    most_expensive_building = building;
                }
            }
            return most_expensive_building;
        }
        public List<Building> FindOverdue(List<Building> buildings)
        {
            List<Building> overdue_buildings = new List<Building>();

            foreach (Building building in buildings)
            {
                if (building.AmortizationPeriod <= 0) overdue_buildings.Add(building);
            }

            if (overdue_buildings.Count > 0) return overdue_buildings;
            return null;
        }

    }
}
