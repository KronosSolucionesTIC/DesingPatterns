namespace DesignPatterns.StrategyPattern
{
    public class BicycleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bicicleta y me muevo en 2 ruedas");
        }
    }
}
