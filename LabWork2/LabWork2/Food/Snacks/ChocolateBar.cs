using LabWork2.Interfaces;

namespace LabWork2.Food.Snacks
{
    public class ChocolateBar : ISnacks
    {
        public string Name { get; set; } = String.Empty;
        public bool Carbohydrates { get; } = true;
        public bool Proteins { get; } = false;
        public bool Fats { get; } = false;


    }
}
