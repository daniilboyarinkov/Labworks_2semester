namespace LabWork2.Interfaces
{
    public interface IFood : IThing
    {
        public bool Proteins { get; }
        public bool Fats { get; }
        public bool Carbohydrates { get; }

    }
}
