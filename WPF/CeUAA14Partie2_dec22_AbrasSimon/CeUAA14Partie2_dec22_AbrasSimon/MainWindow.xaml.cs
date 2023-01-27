using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace CeUAA14Partie2_dec22_AbrasSimon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PrepareInterface();
        }
        // Création du joueur
        Player player = new Player();
        // Préparation de l'interface
        public Button[,] buttons = new Button[10, 10];
        public void PrepareInterface()
        {
            // Création du quadrillage
            Structure structure = new Structure();
            structure.CreateQuadrillage();
            // Placement du pion du joueur
            buttons[0, 0].Content = player.Pawn;
            buttons[0, 0].Foreground = Brushes.Gold;
        }
        // Evenement click
        private void play_Click(object sender, RoutedEventArgs e)
        {
            player.TourJoueur();
        }
    }
}