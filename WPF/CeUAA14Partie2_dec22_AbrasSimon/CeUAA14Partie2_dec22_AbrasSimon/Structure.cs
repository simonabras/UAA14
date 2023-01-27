using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CeUAA14Partie2_dec22_AbrasSimon
{
    internal class Structure
    {
        // Methods
        public void CreateQuadrillage()
        {
            MainWindow game = (CeUAA14Partie2_dec22_AbrasSimon.MainWindow)App.Current.MainWindow;
            // Construction des colonnes
            ColumnDefinition[] coldef = new ColumnDefinition[10];
            for (int i = 0; i < coldef.Length; i++)
            {
                coldef[i] = new ColumnDefinition();
                game.grid2.ColumnDefinitions.Add(coldef[i]);
            }
            // Construction des lignes
            RowDefinition[] rowdef = new RowDefinition[10];
            for (int i = 0; i < rowdef.Length; i++)
            {
                rowdef[i] = new RowDefinition();
                game.grid2.RowDefinitions.Add(rowdef[i]);
            }
            // Constrution des boutons
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    game.buttons[i, j] = new Button();
                    game.buttons[i, j].Width = 60;
                    game.buttons[i, j].Height = 60;
                    game.buttons[i, j].Content = CalculNumero(i, j).ToString();
                    Grid.SetRow(game.buttons[i, j], i);
                    Grid.SetColumn(game.buttons[i, j], j); game.grid2.Children.Add(game.buttons[i, j]);
                    game.buttons[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    game.buttons[i, j].VerticalAlignment = VerticalAlignment.Center;
                    if (CalculNumero(i, j) % 2 == 0)
                    {
                        game.buttons[i, j].Background = Brushes.Aqua;
                    }
                    else
                    {
                        game.buttons[i, j].Background = Brushes.Red;
                    }
                }
            }
        }

        public int CalculNumero(int i, int j)
        {
            if (i % 2 == 0)
            {
                return ((10 * i) + j + 1);
            }
            else
            {
                return ((10 * i) + 10 - j);
            }
        }
    }
}
