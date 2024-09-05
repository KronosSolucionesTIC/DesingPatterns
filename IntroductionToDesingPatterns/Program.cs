using System;

namespace IntroductionToDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVolador> aves = new List<IVolador>();
            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            aves.Add(pato1);
            aves.Add(pato2);
            aves.Add(pato3);
            var gallina = new Gallina();
            aves.Add(gallina);

            AVolar(aves);
        }

        interface IVolador
        {
            public void Vuela();
        }

        static void AVolar(List<IVolador> aves)
        {
            foreach (var ave in aves)
            {
                ave.Vuela();
            }
        }

        interface ICaminador
        {
            public void Camina();
        }

        public class Pato : IVolador, ICaminador
        {
            public void Camina()
            {
                Console.WriteLine("pato camina");
            }

            public void Vuela()
            {
                Console.WriteLine("pato vuela");
            }
        }

        public class Gallina : IVolador
        {
            public void Vuela()
            {
                Console.WriteLine("gallina vuela");
            }
        }
    }
}