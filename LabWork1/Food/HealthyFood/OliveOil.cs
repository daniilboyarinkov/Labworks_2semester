using LabWork2.Interfaces;

namespace LabWork2.Food.HealthyFood
{
    public class OliveOil : IHealthyFood
    {
        public string Name { get; set; } = String.Empty;
        public bool Carbohydrates { get; } = false;
        public bool Proteins { get; } = false;
        public bool Fats { get; } = true;


    }
}
