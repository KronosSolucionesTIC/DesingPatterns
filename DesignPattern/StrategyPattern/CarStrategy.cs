namespace DesignPatterns.StrategyPattern
{
    public class CarStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un carro y me muevo con 4 ruedas");
        }
    }
}
