using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Levriers
{
    internal class Dog
    {
        // Private attributes
        private int _number; // Numéro du chien
        private BitmapImage _image; // Image du chien
        private int _speed; // Multiplicateur de vitesse
        private int _position; // Position du chien

        // Constructor
        public Dog(int number, BitmapImage image, int speed, int position)
        {
            this._number = number;
            this._image = image;
            this._speed = speed;
            this._position = position;
        }

        // Properties
        public int Number
        {
            get { return _number; }
            //set { _number = value; }
        }
        public BitmapImage Image
        {
            get { return _image; }
            //set { _image = value; }
        }
        public int Speed
        {
            get { return _speed; }
            //set { _speed = value; }
        }
        public int Position
        {
            get { return _position; }
            //set { _position = value; }
        }

        // Methods
        public bool Run() // Courir
        {
            _position -= 50 * _speed;
            return true;
        }
    }
}
