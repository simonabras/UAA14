namespace ACT4
{
    class Cercle
    {
        // Private attributes
        private double _rayon;

        // Constructor
        public Cercle(double rayon)
        {
            this._rayon = rayon;
        }

        // Properties
        public double Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

        // Methods
        public double CalculePerimetre()
        {
            return Math.Round(2 * Math.PI * this._rayon, 2);
        }
        public double CalculeAire()
        {
            return Math.Round(Math.PI * this._rayon * this._rayon, 2);
        }
        public string GetAttributes()
        {
            return $"Rayon du cercle : {this._rayon}";
        }
    }
}