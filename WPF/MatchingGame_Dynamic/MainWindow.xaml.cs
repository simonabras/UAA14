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

namespace MatchingGame_Dynamic
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

        // Préparation de l'interface
        public void PrepareInterface()
        {
            // Dismention de la fenêtre
            this.Width = 400;
            this.Height = 450;
            // Construction des lignes
            RowDefinition[] rowdef = new RowDefinition[4];
            for (int i = 0; i < rowdef.Length; i++)
            {
                rowdef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowdef[i]);
            }

            // Construction des colonnes
            ColumnDefinition[] coldef = new ColumnDefinition[4];
            for (int i = 0; i < coldef.Length; i++)
            {
                coldef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(coldef[i]);
            }

            // Constrution des textblocks
            TextBlock[,] txtB = new TextBlock[4, 4];
            for (int i = 0; i < txtB.GetLength(0); i++)
            {
                for (int j = 0; j < txtB.GetLength(1); j++)
                {
                    txtB[i, j] = new TextBlock();
                    txtB[i, j].Text = "?";
                    txtB[i, j].FontSize = 30;
                    txtB[i, j].FontWeight = FontWeights.Bold;
                    txtB[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    txtB[i, j].VerticalAlignment = VerticalAlignment.Center;
                    txtB[i, j].MouseDown += new MouseButtonEventHandler(txtB_Click);
                    Grid.SetRow(txtB[i, j], i);
                    Grid.SetColumn(txtB[i, j], j);
                    grdMain.Children.Add(txtB[i, j]);
                }
            }
        }

        // Evènement qui se déclenche lorsqu'on clique sur un textblock
        public void txtB_Click(object sender, MouseButtonEventArgs e)
        {
            ((TextBlock)sender).Text = "X";
        }
    }
}
