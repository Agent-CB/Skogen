
using System;
using System.Collections.Generic;

namespace Skogen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar fem djur med namn, nattaktivitet och rörelse
            Animal varg = new Animal("Varg", true, "smyger omkring och letar sitt byte");
            Animal fladdermus = new Animal("Fladdermus", true, "flyger runt bland träden i jakt på mat");
            Animal delfin = new Animal("Delfin", false, "simmar runt och letar efter fisk");
            Animal orn = new Animal("Örn", false, "flyger över skogen och letar efter mat");
            Animal hast = new Animal("Häst", false, "springer genom skogen");

            // Samlar alla djur i en lista
            List<Animal> forrest = new List<Animal>
            {
                varg,
                fladdermus,
                delfin,
                orn,
                hast
            };

            // Låter användaren välja dag eller natt
            Console.WriteLine("Välj tid på dygnet:");
            Console.WriteLine("[D] Dag");
            Console.WriteLine("[N] Natt");

            ConsoleKeyInfo val = Console.ReadKey(true);

            // Om användaren väljer natt
            if (val.Key == ConsoleKey.N)
            {
                Console.WriteLine("\nDet är natt i skogen!\n");

                // Går igenom varje djur i listan
                foreach (Animal djur in forrest)
                {
                    if (djur.Nocturnal)
                    {
                        // Nattaktiva djur är vakna
                        Console.WriteLine(djur.Name + " " + djur.Movement);
                    }
                    else
                    {
                        // Djur som inte är nattaktiva sover
                        Console.WriteLine(djur.Name + " sover.");
                    }
                }
            }
            // Om användaren väljer dag
            else if (val.Key == ConsoleKey.D)
            {
                Console.WriteLine("\nDet är dag i skogen!\n");

                // Går igenom varje djur i listan
                foreach (Animal djur in forrest)
                {
                    if (djur.Nocturnal)
                    {
                        // Nattaktiva djur sover på dagen
                        Console.WriteLine(djur.Name + " sover.");
                    }
                    else
                    {
                        // Övriga djur är vakna på dagen
                        Console.WriteLine(djur.Name + " " + djur.Movement);
                    }
                }
            }
            else
            {
                // Om användaren väljer en annan tangent
                Console.WriteLine("\nOgiltigt val. Välj D eller N.");
            }

            // Väntar på en tangent innan programmet avslutas
            Console.WriteLine("\nTryck på valfri tangent för att avsluta.");
            Console.ReadKey();
        }

        // Klass som beskriver ett djur
        class Animal
        {
            // Djurets namn
            public string Name { get; set; }

            // Anger om djuret är nattaktivt
            public bool Nocturnal { get; set; }

            // Beskriver hur djuret rör sig eller vad det gör
            public string Movement { get; set; }

            // Constructor som tar emot djurets egenskaper
            public Animal(string name, bool nocturnal, string movement)
            {
                Name = name;
                Nocturnal = nocturnal;
                Movement = movement;
            }
        }
    }
}
