﻿namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme sur le cercle !");
            Console.WriteLine("Entrez un rayon pour votre cercle");
            double rayon = double.Parse(Console.ReadLine());

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