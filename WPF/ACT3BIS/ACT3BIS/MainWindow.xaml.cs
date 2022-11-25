using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ACT3BIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int period;
        double weeksCount;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Poeples_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox poeplesBox = ((TextBox)sender);
            if (!int.TryParse(e.Text, out int number))
            {
                e.Handled = true;
            }
            if(number < 1 || number > 6)
            {
                e.Handled = true;
            }
            if(poeplesBox.Text != String.Empty)
            {
                e.Handled = true;
            }
        }

        // Calculer le temps du séjour
        private void CalculTime_Click(object sender, RoutedEventArgs e)
        {
            TextBox date1Box = this.FindName("Date1") as TextBox;
            TextBox date2Box = this.FindName("Date2") as TextBox;
            TextBlock weeksBlock = this.FindName("Weeks") as TextBlock;
            // Vérifier si la date est valide
            if (DateTime.TryParse(date1Box.Text, out DateTime date1) && DateTime.TryParse(date2Box.Text, out DateTime date2))
            {
                // Vérifier si la période est valide
                if(((date1.Month == 12 || date1.Month == 1) && (date2.Month == 12 || date2.Month == 1)) || ((date1.Month == 7 || date1.Month == 8) && (date2.Month == 7 || date2.Month == 8)) || (date1.Month == 4 && date2.Month == 4))
                {
                    period = date1.Month;
                    weeksCount = Math.Ceiling((date2 - date1).TotalDays / 7);
                    // Vérifier si la durée est valide
                    if (weeksCount > 0 && weeksCount < 10)
                    {
                        weeksBlock.Text = weeksCount.ToString();
                        weeksBlock.Foreground = Brushes.Green;
                    }
                    else
                    {
                        weeksBlock.Text = "Durée invalide";
                        weeksBlock.Foreground = Brushes.Red;
                    }
                }
                else
                {
                    weeksBlock.Text = "Période invalide";
                    weeksBlock.Foreground = Brushes.Red;
                }
            }
            else
            {
                weeksBlock.Text = "Date invalide";
                weeksBlock.Foreground = Brushes.Red;
            }
        }

        // Calculer le prix de séjour
        private void CalculPrice_Click(object sender, RoutedEventArgs e)
        {
            RadioButton chaletRadio = this.FindName("Chalet") as RadioButton;
            RadioButton tentRadio = this.FindName("Tent") as RadioButton;
            TextBox poeplesBox = this.FindName("Poeples") as TextBox;
            CheckBox reservationBox = this.FindName("Reservation") as CheckBox;
            TextBlock priceBlock = this.FindName("Price") as TextBlock;
            // Vérifier si tout est rempli
            if (poeplesBox.Text != String.Empty && (chaletRadio.IsChecked.Value || tentRadio.IsChecked.Value))
            {
                // Vérifier si la durée est valide
                if (weeksCount > 0)
                {
                    double price = 0;
                    int poeplesCount = int.Parse(poeplesBox.Text);
                    // Type de logement
                    if (chaletRadio.IsChecked.Value)
                    {
                        // Période
                        if (period == 7 || period == 8)
                        {
                            // Nombre de personnes
                            if (poeplesCount <= 4)
                            {
                                price = 547 * weeksCount;
                            }
                            else if (poeplesCount == 5)
                            {
                                price = 581 * weeksCount;
                            }
                            else
                            {
                                price = 599 * weeksCount;
                            }
                        }
                        else
                        {
                            // Nombre de personnes
                            if (poeplesCount <= 4)
                            {
                                price = 297 * weeksCount;
                            }
                            else if (poeplesCount == 5)
                            {
                                price = 330 * weeksCount;
                            }
                            else
                            {
                                price = 347 * weeksCount;
                            }
                        }
                    }
                    else if (tentRadio.IsChecked.Value)
                    {
                        // Période
                        if (period == 7 || period == 8)
                        {
                            // Nombre de personnes
                            if (poeplesCount <= 4)
                            {
                                price = 349 * weeksCount;
                            }
                            else if (poeplesCount == 5)
                            {
                                price = 380 * weeksCount;
                            }
                            else
                            {
                                price = 390 * weeksCount;
                            }
                        }
                        else
                        {
                            // Nombre de personnes
                            if (poeplesCount <= 4)
                            {
                                price = 198 * weeksCount;
                            }
                            else if (poeplesCount == 5)
                            {
                                price = 220 * weeksCount;
                            }
                            else
                            {
                                price = 250 * weeksCount;
                            }
                        }
                    }
                    // Taxe de séjour
                    price += 0.3 * poeplesCount * weeksCount * 7;
                    // Frais de réservation
                    if (reservationBox.IsChecked.Value)
                    {
                        price += 12;
                    }
                    // Remise selon la durée du séjour
                    if (weeksCount >= 5)
                    {
                        price -= (price / 100) * 10;
                    }
                    else if (weeksCount >= 3)
                    {
                        price -= (price / 100) * 5;
                    }
                    priceBlock.Text = $"{price}€";
                    priceBlock.Foreground = Brushes.Green;
                }
                else
                {
                    priceBlock.Text = "Durée invalide";
                    priceBlock.Foreground = Brushes.Red;
                }
            }
            else
            {
                priceBlock.Text = "Donnée(s) manquante(s)";
                priceBlock.Foreground = Brushes.Red;
            }
        }
    }
}
