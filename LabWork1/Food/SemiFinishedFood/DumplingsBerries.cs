using LabWork2.Interfaces;

namespace LabWork2.Food.SemiFinishedFood
{
    public class DumplingsBerries : ISemiFinishedFood
    {
        public string Name { get; set; } = String.Empty;
        public bool Carbohydrates { get; } = true;
        public bool Proteins { get; } = false;
        public bool Fats { get; } = false;


    }
}
