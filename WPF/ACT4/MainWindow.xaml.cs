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

namespace ACT4
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

        public void PrepareInterface()
        {
            RowDefinition rowdef1 = new RowDefinition();
            RowDefinition rowdef2 = new RowDefinition();
            RowDefinition rowdef3 = new RowDefinition();
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();

            grdMain.RowDefinitions.Add(rowdef1);
            grdMain.RowDefinitions.Add(rowdef2);
            grdMain.RowDefinitions.Add(rowdef3);
            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);

            Thickness myThickness = new Thickness();
            myThickness.Bottom = 20;

            Thickness myThickness2 = new Thickness();
            myThickness2.Top = 20;
            myThickness2.Right = 20;

            TextBlock txtBC1 = new TextBlock();
            txtBC1.Text = "TextBlock crée dynamiquement";
            txtBC1.FontWeight = FontWeights.Bold;
            txtBC1.FontSize = 20;
            txtBC1.Foreground = Brushes.Blue;
            txtBC1.Background = Brushes.Yellow;
            txtBC1.Height = 60;
            txtBC1.Margin = myThickness;

            TextBlock txtBC2 = new TextBlock();
            txtBC2.Text = "Infos :";
            txtBC2.FontWeight = FontWeights.Bold;
            txtBC2.FontSize = 20;
            txtBC2.Foreground = Brushes.Black;
            txtBC2.Background = Brushes.Yellow;

            TextBox txtBX1 = new TextBox();
            txtBX1.Text = "J'attends vos infos";

            Button btn1 = new Button();
            btn1.Content = "BOUTON 1";
            btn1.Height = 150;
            btn1.Width = 200;
            btn1.Foreground = Brushes.White;
            btn1.Background = Brushes.Black;

            Button btn2 = new Button();
            btn2.Content = "BOUTON 2";
            btn2.Height = 150;
            btn2.Width = 200;
            btn2.Foreground = Brushes.White;
            btn2.Background = Brushes.Black;

            Button btn3 = new Button();
            btn3.Content = "BOUTON 3";
            btn3.Height = 150;
            btn3.Width = 200;
            btn3.Foreground = Brushes.White;
            btn3.Background = Brushes.Black;

            StackPanel stkP1 = new StackPanel();
            stkP1.Margin = myThickness2;
            stkP1.Children.Add(txtBC2);
            stkP1.Children.Add(txtBX1);

            ComboBox combB1 = new ComboBox();
            combB1.Height = 100;
            combB1.Width = 100;
            combB1.Items.Add("Info 1");
            combB1.Items.Add("Info 2");

            Grid.SetRow(btn1, 1);
            Grid.SetRow(btn2, 1);
            Grid.SetRow(btn3, 1);
            Grid.SetRow(combB1, 2);
            Grid.SetColumn(btn1, 0);
            Grid.SetColumn(btn2, 1);
            Grid.SetColumn(btn3, 2);
            Grid.SetColumn(combB1, 2);
            Grid.SetRow(stkP1, 2);
            Grid.SetColumnSpan(stkP1, 2);
            Grid.SetColumnSpan(txtBC1, 3);

            grdMain.Children.Add(txtBC1);
            grdMain.Children.Add(btn1);
            grdMain.Children.Add(btn2);
            grdMain.Children.Add(btn3);
            grdMain.Children.Add(stkP1);
            grdMain.Children.Add(combB1);
        }
    }
}
