namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bienvenue dans notre ferme !");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Dog[] dogs = new Dog[2];
            dogs[0] = new Dog("Noisette", new DateTime(2015, 12, 25), 1, 82, false);
            dogs[1] = new Dog("Pierre", new DateTime(2013, 10, 16), 2, 102, true);
            Cat[] cats = new Cat[2];
            cats[0] = new Cat("Jean-Claude", new DateTime(2010, 02, 26), 1, 23, false);
            cats[1] = new Cat("Mikado", new DateTime(2019, 10, 13), 2, 21, true);
            Rabbit[] rabbits = new Rabbit[2];
            rabbits[0] = new Rabbit("Maya", new DateTime(2020, 08, 10), 1, 12, false, 6);
            rabbits[1] = new Rabbit("Oreo", new DateTime(2021, 04, 19), 2, 11, false, 5);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Nous avons {dogs.Length} chien(s), {cats.Length} chat(s) et {rabbits.Length} lapin(s)");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Random number = new Random();
            Console.WriteLine(cats[number.Next(0, cats.Length - 1)].Purr());
            Console.WriteLine(rabbits[number.Next(0, rabbits.Length - 1)].Jump());
            Console.WriteLine(dogs[number.Next(0, dogs.Length - 1)].Bark());
            Console.WriteLine(cats[number.Next(0, cats.Length - 1)].Meow());
            Console.WriteLine(dogs[number.Next(0, dogs.Length - 1)].Sleep());
            Console.WriteLine(rabbits[number.Next(0, rabbits.Length - 1)].Eat());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Voici les caractéristiques de nos animaux");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for(int i=0; i < dogs.Length; i++)
            {
                Console.WriteLine($"{dogs[i].Name} est né(e) le {dogs[i].BirthDate.ToString("dd/MM/yyyy")}, son numéro de puce est le {dogs[i].Number}. Il/elle mesure {dogs[i].Size}cm et {(dogs[i].Competition ? "fait des compétitions" : "ne fait pas de compétitions")}.");
            }
            for(int i=0; i < cats.Length; i++)
            {
                Console.WriteLine($"{cats[i].Name} est né(e) le {cats[i].BirthDate.ToString("dd/MM/yyyy")}, son numéro de puce est le {cats[i].Number}. Il/elle mesure {cats[i].Size}cm et {(cats[i].Competition ? "fait des compétitions" : "ne fait pas de compétitions")}.");
            }
            for(int i=0; i < rabbits.Length; i++)
            {
                Console.WriteLine($"{rabbits[i].Name} est né(e) le {rabbits[i].BirthDate.ToString("dd/MM/yyyy")}, son numéro de puce est le {rabbits[i].Number}. Il/elle mesure {rabbits[i].Size}cm, ses oreilles font {rabbits[i].EarsSize}cm et {(rabbits[i].Competition ? "fait des compétitions" : "ne fait pas de compétitions")}.");
            }
        }
    }
}