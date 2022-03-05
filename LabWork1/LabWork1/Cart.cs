using LabWork2.Interfaces;

namespace LabWork2
{
    public class Cart<T> where T : IFood
    {
        public List<T> FoodStuffs { get; set; } = new List<T>();
        public string Filter { get; set; } = "1";
        private List<T> FilterFoodStuff(List<T> AllFood)
        {
            if (Filter == "2") return AllFood.FindAll(food => food is IHealthyFood);
            else if (Filter == "3") return AllFood.FindAll(food => food is ISemiFinishedFood);
            else if (Filter == "4") return AllFood.FindAll(food => food is ISnacks);
            return AllFood;
        }
        public string CartBalancing(List<T> AllFood)
        {
            FoodStuffs = FilterFoodStuff(FoodStuffs);
            AllFood = FilterFoodStuff(AllFood);
            int CountFats = FoodStuffs.FindAll(food => food.Fats == true).Count;
            int CountProteins = FoodStuffs.FindAll(food => food.Proteins == true).Count;
            int CountCarbohydrates = FoodStuffs.FindAll(food => food.Carbohydrates == true).Count;
            while (CountFats != CountProteins || CountProteins != CountCarbohydrates || CountFats != CountCarbohydrates)
            {
                int min = new int[] { CountFats, CountProteins, CountCarbohydrates }.Min();
                if ( min == CountFats)
                {
                    try { 
                        T? food = AllFood.Find(food => food.Fats == true);
                        if (food != null) FoodStuffs.Add(food);
                        else return "Не удалось сбалансировать корзину...";
                        CountFats++; 
                    }
                    catch { return "Не удалось сбалансировать корзину..."; }
                }
                else if (min == CountProteins)
                {
                    try { 
                        T? food = AllFood.Find(food => food.Proteins == true); 
                        if (food != null) FoodStuffs.Add(food);
                        else return "Не удалось сбалансировать корзину...";
                        CountProteins++; 
                    }
                    catch { return "Не удалось сбалансировать корзину..."; }
                }
                else if (min == CountCarbohydrates)
                {
                    try { 
                        T? food = AllFood.Find(food => food.Carbohydrates == true); 
                        if (food != null) FoodStuffs.Add(food); 
                        else return "Не удалось сбалансировать корзину...";
                        CountCarbohydrates++; 
                    }
                    catch { return "Не удалось сбалансировать корзину..."; }
                }
            }
            return "Корзина сбалансирована!";
        }
        public string PrintCart()
        {
            string result = String.Empty;
            result += "\n\tСейчас в вашей корзине: \n\n";
            FoodStuffs.ForEach(food => result += $"\t{food.Name}\n");
            return result;
        }
    }
}
