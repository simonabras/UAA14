namespace ACT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant1 = new Elephant("Zazou", 35);
            Elephant elephant2 = new Elephant("Titi", 40);

            Console.WriteLine("Entrez 1 pour afficher les attributs de " + elephant1.GetName());
            Console.WriteLine("Entrez 2 pour afficher les attributs de " + elephant2.GetName());
            Console.WriteLine("Entrez 3 pour permuter les références pointant vers ces objets et afficher les caractéristiques de chaque éléphant");
            Console.WriteLine("Entrez 4 pour transférer un message de " + elephant1.GetName() + " à " + elephant2.GetName());

            while(true)
            {
                string action = Console.ReadLine();
                switch(action)
                {
                    case "1":
                        Console.WriteLine(elephant1.GetAttributes());
                        break;
                    case "2":
                        Console.WriteLine(elephant2.GetAttributes());
                        break;
                    case "3":
                        Elephant save = elephant1;
                        elephant1 = elephant2;
                        elephant2 = save;
                        Console.WriteLine(elephant1.GetAttributes());
                        Console.WriteLine(elephant2.GetAttributes());
                        break;
                    case "4":
                        Console.WriteLine(elephant1.SendMessage("test", elephant2));
                        break;
                }
            }
        }
    }
}