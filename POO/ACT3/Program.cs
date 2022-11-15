namespace ACT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant[] elephants = new Elephant[2];
            elephants[0] = new Elephant("Zazou", 35);
            elephants[1] = new Elephant("Titi", 40);

            Console.WriteLine("Entrez 1 pour afficher les attributs de " + elephants[0].GetName());
            Console.WriteLine("Entrez 2 pour afficher les attributs de " + elephants[1].GetName());
            Console.WriteLine("Entrez 3 pour permuter les références pointant vers ces objets et afficher les caractéristiques de chaque éléphant");
            Console.WriteLine("Entrez 4 pour transférer un message de " + elephants[0].GetName() + " à " + elephants[1].GetName());
            Console.WriteLine("Entrez 5 pour afficher l'éléphant qui a la plus grande oreille");

            while(true)
            {
                string action = Console.ReadLine();
                switch(action)
                {
                    case "1":
                        Console.WriteLine(elephants[0].GetAttributes());
                        break;
                    case "2":
                        Console.WriteLine(elephants[1].GetAttributes());
                        break;
                    case "3":
                        Elephant save = elephants[0];
                        elephants[0] = elephants[1];
                        elephants[1] = save;
                        Console.WriteLine(elephants[0].GetAttributes());
                        Console.WriteLine(elephants[1].GetAttributes());
                        break;
                    case "4":
                        Console.WriteLine(elephants[0].SendMessage("test", elephants[1]));
                        break;
                    case "5":
                        int index = 0;
                        uint maxValue = 0;
                        for(int i = 0; i < elephants.Length; i++)
                        {
                            uint n = elephants[i].GetSizeEars();
                            if(n > maxValue)
                            {
                                index = i;
                                maxValue = n;
                            }
                        }
                        Console.WriteLine(elephants[index].GetAttributes());
                        break;
                }
            }
        }
    }
}