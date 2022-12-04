namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while(again)
            {
                Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !");

                Console.WriteLine("Entrez le nom de la première personne");
                string name1 = Console.ReadLine();
                Console.WriteLine("Entrez l'argent de la première personne");
                int money1 = int.Parse(Console.ReadLine());
                Personne personne1 = new Personne(name1, money1);

                Console.WriteLine("Entrez le nom de la deuxième personne");
                string name2 = Console.ReadLine();
                Console.WriteLine("Entrez l'argent de la deuxième personne");
                int money2 = int.Parse(Console.ReadLine());
                Personne personne2 = new Personne(name2, money2);

                Console.WriteLine($"{personne1.Name} combien voulez-vous donner à {personne2.Name} ?");
                int amount1 = int.Parse(Console.ReadLine());
                personne1.RemoveMoney(amount1); // ou personne1.Money -= amount1
                personne2.AddMoney(amount1); // ou personne2.Money += amount1
                Console.WriteLine("Ajout effecué !");
                Console.WriteLine(personne1.AffichePersonne());
                Console.WriteLine(personne2.AffichePersonne());

                Console.WriteLine($"{personne2.Name} combien voulez-vous donner à {personne1.Name} ?");
                int amount2 = int.Parse(Console.ReadLine());
                personne2.RemoveMoney(amount2); // ou personne2.Money -= amount2
                personne1.AddMoney(amount2); // ou personne1.Money += amount2
                Console.WriteLine("Ajout effecué !");
                Console.WriteLine(personne1.AffichePersonne());
                Console.WriteLine(personne2.AffichePersonne());

                Console.WriteLine($"Voulez-vous ajouter de l'argent au compte de {personne1.Name} ? (entrez espace pour oui)");
                string response1 = Console.ReadLine();
                if(response1 == " ")
                {
                    Console.WriteLine("Combien voulez-vous ajouter ?");
                    int amount3 = int.Parse(Console.ReadLine());
                    personne1.AddMoney(amount3); // ou personne1.Money += amount3
                    Console.WriteLine(personne1.AffichePersonne());
                    Console.WriteLine(personne2.AffichePersonne());
                }
                Console.WriteLine("Entrez espace pour recommencer avec des autres personnes");
                string response2 = Console.ReadLine();
                if(response2 != " ")
                {
                    again = false;
                }
            }
        }
    }
}