namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre concepteur de sandwish !");
            bool again = true;
            while(again)
            {
                Console.WriteLine("Entrez espace pour générer un sandwish, n'impote quelle touche pour quitter !");
                string response1 = Console.ReadLine();
                if(response1 == " ")
                {
                    SandwichMaker sandwich = new SandwichMaker();
                    string chaine = sandwich.ComposeSandwish();
                    Console.WriteLine(chaine);
                }
                else
                {
                    again = false;
                }
            }
        }
    }
}