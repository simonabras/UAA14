using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace MatchingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        TextBlock lastClick;
        int timeEslaped = 0;
        int countPairFind = 0;
        bool pair = false;
        public MainWindow()
        {
            InitializeComponent();
            SetupGame();
            timer.Tick += new EventHandler(Timer_Tick);
        }

        // Préparer le jeu
        private void SetupGame()
        {
            int index;
            string nextEmoji;
            Random nbAlea = new Random();

            List<string> animalEmoji = new List<string>()
            {
                "🐶","🐶",
                "🦊","🦊",
                "🐻","🐻",
                "🐵","🐵",
                "🐹","🐹",
                "🐥","🐥",
                "🦋","🦋",
                "🐳","🐳",
            };
            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "txtTime")
                {
                    index = nbAlea.Next(animalEmoji.Count); // index est de type int
                                                            // nbalea est un objet de type Random()
                    nextEmoji = animalEmoji[index]; // nextEmoji est de type string
                    textBlock.Text = nextEmoji;
                    textBlock.Visibility = Visibility.Visible;
                    animalEmoji.RemoveAt(index); // on retire un animal de la liste pour ne pas l’attribuer à nouveau.
                }
            }

            timer.Interval = TimeSpan.FromSeconds(.1);
            timeEslaped = 0;
            countPairFind = 0;
            timer.Start();

        }

        // Répondre à l'évènement "TextBlock_MouseDown"
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockActif = sender as TextBlock;
            if (!pair)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                lastClick = textBlockActif;
                pair = true;
            }
            else if (textBlockActif.Text == lastClick.Text)
            {
                countPairFind++;
                textBlockActif.Visibility = Visibility.Hidden;
                pair = false;
            }
            else
            {
                lastClick.Visibility = Visibility.Visible;
                pair = false;
            }

        }

        // Répondre à l'évènement "txtTime_MouseDown"
        private void txtTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (countPairFind == 8)
            {
                SetupGame();
            }
        }


        // Répondre à l'évènement "TimerTick"
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeEslaped++;
            txtTime.Text = (timeEslaped / 10F).ToString("0.0s");
            if (countPairFind == 8)
            {
                timer.Stop();
                txtTime.Text = txtTime.Text + " - Rejouer ? ";
            }
        }

    }
}
