using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CeUAA14Partie2_dec22_AbrasSimon
{
    internal class Player
    {
        // Private attributes
        private int _id = 1;
        private int _total = 1;
        private int[] _position = { 0, 0 };
        private string _oldValue = "1";
        private string _pawn = "X";

        // Properties
        public string Pawn
        {
            get { return _pawn; }
        }

        // Methods
        public void TourJoueur()
        {
            MainWindow game = (CeUAA14Partie2_dec22_AbrasSimon.MainWindow)App.Current.MainWindow;
            Random alea = new Random();
            int de = alea.Next(1, 7);
            game.txtPlayer.Text = $"Joueur : {_id}";
            game.txtDice.Text = $"Dé : {de}";
            game.buttons[_position[0], _position[1]].Content = _oldValue;
            game.buttons[_position[0], _position[1]].Foreground = Brushes.Black;
            _total += de;
            int reste = _total - 10 * (_position[0] + 1);
            if (reste < 0)
            {
                reste += 10;
            }
            else
            {
                _position[0] += 1;
            }
            if (_position[0] % 2 != 0)
            {
                _position[1] = 9 - reste;
            }
            else
            {
                _position[1] = reste;
            }
            if (_position[0] <= 9)
            {
                _oldValue = game.buttons[_position[0], _position[1]].Content.ToString();
                game.buttons[_position[0], _position[1]].Content = _pawn;
                game.buttons[_position[0], _position[1]].Foreground = Brushes.Gold;
            }
            else
            {
                game.txtPlayer.Text = "Fin !";
                game.buttons[9, 0].Content = _pawn;
                game.buttons[9, 0].Foreground = Brushes.Gold;
                game.btnPlay.IsEnabled = false;
            }
        }
    }
}
