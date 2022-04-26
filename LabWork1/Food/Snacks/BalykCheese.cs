using LabWork2.Interfaces;

namespace LabWork2.Food.Snacks
{
    public class BalykCheese : ISnacks
    {
        public string Name { get; set; } = String.Empty;
        public bool Carbohydrates { get; } = false;
        public bool Proteins { get; } = true;
        public bool Fats { get; } = false ;

    }
}
