namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        public void Reset();
        public void SetAlcohol(decimal alcohol);
        public void SetWather(int water);
        public void SetMilk(int milk);
        public void AddIngredients(string ingredients);
        public void Mix();
        public void Rest(int time);
    }
}
