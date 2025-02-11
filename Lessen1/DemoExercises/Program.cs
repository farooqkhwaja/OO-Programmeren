namespace DemoExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person person1 = new Person();
            //person1.name = "farooq";

            //Console.WriteLine(person1);
            //Random rnd = new Random();

            int aantalAutos = 2;
            Auto[] autos = new Auto[aantalAutos];

            for (int i = 0; i < aantalAutos; i++)
            {
                Auto nieuweAuto = new Auto();
                autos[i] = nieuweAuto;

                Console.WriteLine($"Kilometerstand van auto {i + 1}?");
                nieuweAuto.Kilometers = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Benzinepeil van auto {i + 1}?");
                nieuweAuto.Benzine = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Jaar recentste onderhoud auto {i + 1}?");
                int jaar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Maand recentste onderhoud auto {i + 1}?");
                int maand = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Dag recentste onderhoud auto {i + 1}?");
                int dag = Convert.ToInt32(Console.ReadLine());

                nieuweAuto.LaatsteOnderhoud = new DateTime(jaar, maand, dag);
            }
            // later in de code
            for (int i = 0; i < aantalAutos; i++)
            {
                Console.WriteLine(autos[i].Benzine);
            }
        }
    }
    class Auto
    {
        public int Kilometers;
        public double Benzine;
        public DateTime LaatsteOnderhoud;
    }
}
