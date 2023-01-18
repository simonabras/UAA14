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

namespace CalculetteBinaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.nbr1.PreviewTextInput += new TextCompositionEventHandler(nbr_PreviewTextInput);
            this.nbr2.PreviewTextInput += new TextCompositionEventHandler(nbr_PreviewTextInput);
        }

        private void nbr_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = ((TextBox)sender);
            // Vérifier si l'entrée est un entier
            if (!int.TryParse(e.Text, out int number))
            {
                e.Handled = true;
            }
            else
            {
                // Vérifier si l'entrée est plus petit que 0 ou plus grand que 1
                if (number < 0 || number > 1)
                {
                    e.Handled = true;
                }
                // Vérifier si la longueur du texte dans la box est plus grande ou égale à 7 (l'entrée n'est pas comptée)
                if (textBox.Text.Length >= 7)
                {
                    e.Handled = true;
                }
            }
        }

        private void calcul_Click(object sender, RoutedEventArgs e)
        {
            Functions utils = new Functions();
            if(nbr1.Text != "" && nbr2.Text != "" )
            {
                ushort[] binArray1 = utils.CreateArray(nbr1.Text);
                ushort[] binArray2 = utils.CreateArray(nbr2.Text);
                if(addition.IsChecked == true)
                {
                    bool success = utils.Addition(binArray1, binArray2, out ushort[] resultArray);
                    if (success)
                    {
                        string resultChaine = utils.ConvertArrayToString(resultArray);
                        result.Foreground = Brushes.GreenYellow;
                        result.Text = resultChaine;
                    }
                    else
                    {
                        result.Foreground = Brushes.OrangeRed;
                        result.Text = "Erreur";
                    }
                }
                else if(soustraction.IsChecked == true)
                {
                    bool success = utils.Soustraction(binArray1, binArray2, out ushort[] resultArray);
                    if (success)
                    {
                        string resultChaine = utils.ConvertArrayToString(resultArray);
                        result.Foreground = Brushes.GreenYellow;
                        result.Text = resultChaine;
                    }
                    else
                    {
                        result.Foreground = Brushes.OrangeRed;
                        result.Text = "Erreur";
                    }
                }
                else
                {
                    result.Foreground = Brushes.OrangeRed;
                    result.Text = "Erreur";
                }
            }
            else
            {
                result.Foreground = Brushes.OrangeRed;
                result.Text = "Erreur";
            }
        }
    }
}
