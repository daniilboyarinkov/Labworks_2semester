using LabWork2.Interfaces;

namespace LabWork2.Food.HealthyFood
{
    public class Fruit : IHealthyFood
    {
        public string Name { get; set; } = String.Empty;
        public bool Carbohydrates { get; } = true;
        public bool Proteins { get; } = false;
        public bool Fats { get; } = false;


    }
}
