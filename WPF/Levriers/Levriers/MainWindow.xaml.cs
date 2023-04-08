using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Levriers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game = new Game(new TimeSpan(0), 5);
        Player[] players = new Player[3];
        Dog[] dogs = new Dog[4];
        public MainWindow()
        {
            InitializeComponent();
            CreatePlayers();
            CreateDogs();
            UpdateInterface();
        }

        public void CreatePlayers()
        {
            for (int i = 0; i < 3; i++)
            {
                string[] names = { "Béatrice", "Benoit", "Pierre" };
                players[i] = new Player(i, names[i], 50, 0, 0);
            }
        }

        public void CreateDogs()
        {
            BitmapImage dogBitmapImage = new BitmapImage(new Uri("./images/dog.png", UriKind.Relative));
            Random rand = new Random();
            for (int i=0; i<4; i++) {
                Image dogImage = new Image();
                dogImage.Name = "Dog" + i;
                dogImage.Source = dogBitmapImage;

                dogImage.Width = 100;
                dogImage.Height = 100;

                // Position
                int position = 200 - (i * 150);
                dogImage.Margin = new Thickness(-700, 0, 0, position);

                // Vittese
                int[] speeds = { 1, 2, 3, 5 };
                int randomNumber = rand.Next(0, 4);
                int randomSpeed = speeds[randomNumber];

                grdMain.Children.Add(dogImage);
                dogs[i] = new Dog(i, dogBitmapImage, randomSpeed, position);
            }
        }
        
        public void UpdateInterface()
        {
            // Mettre à jour le pari minimum
            Label betMin = (Label)FindName("bet_Min");
            betMin.Content = "Pari minimum : " + game.BetMin + " écus";
            // Mettre à jour la liste des joueurs
            ListBox playersList = (ListBox)FindName("players_List");
            for(int i=0; i<players.Length; i++)
            {
                playersList.Items[i] = players[i].Name + " possède " + players[i].Wallet + " écus";
            }
            playersList.Items.Refresh();

            // Mettre à jour la liste des paris
            ListBox betsList = (ListBox)FindName("bets_List");
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].BetAmount > 0)
                {
                    betsList.Items[i] = players[i].Name + " a parié " + players[i].BetAmount + " écus";
                }
                else
                {
                    betsList.Items[i] = players[i].Name + " n'a pas encore parié";
                }
            }
            betsList.Items.Refresh();

            // Mettre à jour le tour du joueur
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].BetAmount == 0)
                {
                    Label betPlayer = (Label)FindName("bet_Player");
                    betPlayer.Content = players[i].Name;

                    Button betButton = (Button)FindName("Bet");
                    betButton.IsEnabled = true;

                    Button startButton = (Button)FindName("Start");
                    startButton.IsEnabled = false;
                    break;
                } else
                {
                    Button betButton = (Button)FindName("Bet");
                    betButton.IsEnabled = false;

                    Button startButton = (Button)FindName("Start");
                    startButton.IsEnabled = true;
                }
            }
        }

        public void MoveDogs()
        {
            for(int i=0; i<dogs.Length; i++)
            {
                Image dogImage = (Image)FindName("Dog" + i);
                dogImage.Margin = new Thickness(-700, 0, 0, dogs[i].Position);
            }
        }

        private void bet_Click(object sender, RoutedEventArgs e)
        {
            TextBox betNumber = (TextBox)FindName("bet_Number");
            TextBox betAmount = (TextBox)FindName("bet_Amount");
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].BetAmount == 0)
                {
                    int number = int.Parse(betNumber.Text);
                    int amount = int.Parse(betAmount.Text);
                    bool success = players[i].MakeBet(number, amount, game.BetMin);
                    if(success)
                    {
                        UpdateInterface();
                    }
                    break;
                }
            }
        }

        private async void start_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                for (int i = 0; i < dogs.Length; i++)
                {
                    dogs[i].Run();
                }
                MoveDogs();
                await Task.Delay(2000);
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
