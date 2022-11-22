namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme sur le cercle !");
            Console.WriteLine("Entrez la partie réelle du complexe de départ");
            double reel1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la partie imaginaire du complexe de départ");
            double imaginaire1 = double.Parse(Console.ReadLine());

            Complexe complexe1 = new Complexe(reel1, imaginaire1);
            double module1 = complexe1.CalculeModule();
            Console.WriteLine($"Le premier complexe ({complexe1.Reel}, {complexe1.Imaginaire}) a pour module : {module1}");

            Cercle cercle = new Cercle(rayon);
            double perimetre = cercle.CalculePerimetre();
            double aire = cercle.CalculeAire();

            Console.WriteLine($"Le cercle de rayon {cercle.Rayon} a un périmètre de {perimetre} et une aire de {aire}");
            cercle.Rayon /= 2;
            double newPerimetre = cercle.CalculePerimetre();
            double neAaire = cercle.CalculeAire();
            Console.WriteLine($"Le cercle de rayon {cercle.Rayon} a un périmètre de {newPerimetre} et une aire de {neAaire}");
        }
    }
}