namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme sur les complexes !");

            Console.WriteLine("Entrez la partie réelle du complexe de départ");
            double reel1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la partie imaginaire du complexe de départ");
            double imaginaire1 = double.Parse(Console.ReadLine());
            Complexe Complexe1 = new Complexe(reel1, imaginaire1);
            string complexe1 = Complexe1.AfficheComplexe();
            string module1 = Complexe1.CalculeModule();
            Console.WriteLine($"Le premier complexe ({complexe1}) a pour module : {module1}");

            Console.WriteLine("Entrez la partie réelle du second complexe");
            double reel2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la partie imaginaire du second complexe");
            double imaginaire2 = double.Parse(Console.ReadLine());
            Complexe Complexe2 = new Complexe(reel2, imaginaire2);
            string complexe2 = Complexe2.AfficheComplexe();
            Console.WriteLine($"Le second complexe est ({complexe2})");

            Complexe1.Ajout(Complexe2.Reel, Complexe2.Imaginaire);
            // ou Complexe1.Reel += Complexe2.Reel & Complexe1.Imaginaire += Complexe2.Imaginaire
            string newComplexe1 = Complexe1.AfficheComplexe();
            Console.WriteLine($"Le premier complexe devient ({newComplexe1}) après ajout du second");
        }
    }
}