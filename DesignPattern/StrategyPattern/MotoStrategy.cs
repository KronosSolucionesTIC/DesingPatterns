namespace DesignPatterns.StrategyPattern
{
    public class MotoStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una motocicleta y me muevo con 2 llantas");
        }
    }
}
