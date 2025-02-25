using System.Collections.Immutable;

namespace Datastructers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoDictionary();
            PhoneBookNumber();
        }
        public static void DemoDictionary()
        {
            Dictionary<Adress, List<Person>> house = new Dictionary<Adress, List<Person>>();
            Dictionary<int, string> customers = new Dictionary<int, string>();
            customers.Add(123, "Tim Dams");
            customers.Add(6463, "James Bond");
            customers.Add(666, "The beast");
            customers.Add(700, "James Bond");


            customers.Remove(700);

            foreach (var item in customers)
            {
                Console.WriteLine($"{item.Key} , {item.Value}");
            }

            if (customers.ContainsKey(420)) {

                Console.WriteLine(420);
            }
            else
            {
                Console.WriteLine();
            }
        }
        public static void PhoneBookNumber()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            bool stop = true;

            while (stop)
            {
                Console.WriteLine("Welkom bij de oefeningen van objectgeorieenteerd prorgammeren!");
                Console.WriteLine("Topic van de uit te voeren oefening?");

                Console.WriteLine("1.DateTime");
                Console.WriteLine("2.Properties en access modifiers");
                Console.WriteLine("3.Datastructuren");

                string keuze = Console.ReadLine();
                string naam;
                string nummer;

                if (keuze == "3")
                {
                    Console.WriteLine("Uit te voeren oefening?");
                    Console.WriteLine("H13- Phonebook name number");
                    Console.WriteLine("H13- Phonebook city name number");
                    Console.WriteLine("H13- Phonebook with builder");
                    keuze = Console.ReadLine();

                    if (keuze == "1")
                    {
                        Console.WriteLine("Wil je een naam en nummer invoegen?");
                        keuze = Console.ReadLine();
                        if (keuze == "ja")
                        {
                            Console.Write("Naam? ");
                            naam = Console.ReadLine();
                            Console.Write("Nummer? ");
                            nummer = Console.ReadLine();

                            if (phoneBook.ContainsKey(naam))
                            {
                                phoneBook[naam] = nummer;
                            }
                            else
                            {
                                phoneBook.Add(naam, nummer);
                            }


                            Console.WriteLine("Wil je nog een naam toevoegen?");
                            keuze = Console.ReadLine();
                            if (keuze == "ja")
                            {
                                Console.Write("Naam? ");
                                naam = Console.ReadLine();
                                Console.Write("Nummer? ");
                                nummer = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Bedankt!");
                            }
                            foreach (var number in phoneBook)
                            {
                                Console.WriteLine($"{number.Key}: {number.Value} ");
                            }
                        }

                    }

                }

            }

        }
        public static void PhoneBookWithBuilder()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            var BuilderphoneBook = ImmutableDictionary.CreateBuilder<string, string>();

            bool stop = true;

            while (stop)
            {
                Console.WriteLine("Welkom bij de oefeningen van objectgeorieenteerd prorgammeren!");
                Console.WriteLine("Topic van de uit te voeren oefening?");

                Console.WriteLine("1.DateTime");
                Console.WriteLine("2.Properties en access modifiers");
                Console.WriteLine("3.Datastructuren");

                string keuze = Console.ReadLine();
                string naam;
                string nummer;

                if (keuze == "3")
                {
                    Console.WriteLine("Uit te voeren oefening?");
                    Console.WriteLine("H13- Phonebook name number");
                    Console.WriteLine("H13- Phonebook city name number");
                    Console.WriteLine("H13- Phonebook with builder");
                    keuze = Console.ReadLine();

                    if (keuze == "1")
                    {
                        Console.WriteLine("Wil je een naam en nummer invoegen?");
                        keuze = Console.ReadLine();
                        if (keuze == "ja")
                        {
                            Console.Write("Naam? ");
                            naam = Console.ReadLine();
                            Console.Write("Nummer? ");
                            nummer = Console.ReadLine();

                            if (phoneBook.ContainsKey(naam))
                            {
                                phoneBook[naam] = nummer;
                            }
                            else
                            {
                                phoneBook.Add(naam, nummer);
                            }


                            Console.WriteLine("Wil je nog een naam toevoegen?");
                            keuze = Console.ReadLine();
                            if (keuze == "ja")
                            {
                                Console.Write("Naam? ");
                                naam = Console.ReadLine();
                                Console.Write("Nummer? ");
                                nummer = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Bedankt!");
                            }
                            var phoneBooks = BuilderphoneBook
                            foreach (var number in phoneBook)
                            {
                                Console.WriteLine($"{number.Key}: {number.Value} ");

                            }

                        }

                    }

                }

            }

        }
    }
}
