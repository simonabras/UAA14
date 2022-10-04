namespace I1P622_Simon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créer les 2 feux
            Light light1 = new Light("1", 0);
            Light light2 = new Light("2", 0);
            // Fixer le temps à 0
            int time = 0;
            // Nombre aléatoire
            Random n = new Random();
            // Boucle infinie
            while(true)
            {
                // Augmenter le temps de 1
                time++;
                // Si le temps est égal ou supérieur à 5000
                if(time >= 999999999)
                {
                    // Fixer le temps à 0
                    time = 0;
                    // Générer un nombre aléatoire entre 1 et 4 (4 non compris)
                    int color1 = n.Next(1, 4);
                    // Générer un nombre aléatoire entre 0 et 2 (2 non compris)
                    int color2 = n.Next(0, 2);
                    // Changer la couleur des feux
                    light1.ChangeColor(color1);
                    light2.ChangeColor(color2);
                    // Afficher la couleur du feu 1
                    Console.WriteLine(light1.ShowColor());
                    // Afficher l'état du feu 2
                    Console.WriteLine(light2.ShowStatus());
                }
            }
        }
    }
}