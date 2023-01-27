namespace I623_Simon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bienvenue dans ce jeu de tir ... Vous démarrez avec 30 balles");
            Console.WriteLine("-------------------------------------------------------------");
            PaintBallGun paintBallGun = new PaintBallGun(30, 0);
            bool replay = true;
            while(replay)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Vous avez un total de {paintBallGun.PlayerBalls} balle(s) dans votre proche et {paintBallGun.ClipBalls} balle(s) dans le chargeur");
                Console.ForegroundColor = ConsoleColor.White;
                if(paintBallGun.ClipBalls <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Attention votre chargeur est vide !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if(paintBallGun.PlayerBalls <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Attention votre poche est vide !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
                Console.WriteLine("ESPACE pour tirer\nR pour recharger\n+ pour reprendre des munitions\nQ pour quitter");
                bool waitResponse = true;
                while(waitResponse)
                {
                    string response = Console.ReadLine().ToUpper();
                    switch(response)
                    {
                        case " ":
                            bool success = paintBallGun.Shoot();
                            if(success)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("=> Tir effectué !");
                                Console.ForegroundColor = ConsoleColor.White;
                                waitResponse = false;
                            }
                            else {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("=> Vous n'avez plus assez de balles dans le chargeur !");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "R":
                            int balls = paintBallGun.ReloadClip();
                            if(balls > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"=> Recharge de {balls} balle(s) dans le chargeur effectuée !");
                                Console.ForegroundColor = ConsoleColor.White;
                                waitResponse = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"=> Impossible de recharger, soit le chargeur est plein soit vous n'avez plus assez de munitions !");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "+":
                            paintBallGun.ReloadPlayer();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("=> Recharde de 30 balles effectuée !");
                            Console.ForegroundColor = ConsoleColor.White;
                            waitResponse = false;
                            break;
                        case "Q":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("A bientôt !");
                            Console.ForegroundColor = ConsoleColor.White;
                            waitResponse = false;
                            replay = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Merci d'entrer une touche valide !");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
            }
        }
    }
}