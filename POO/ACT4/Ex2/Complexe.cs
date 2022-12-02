namespace Ex2
{
    class Complexe
    {
        // Private attributes
        private double _reel;
        private double _imaginaire;

        // Constructor
        public Complexe(double reel, double imaginaire)
        {
            this._reel = reel;
            this._imaginaire = imaginaire;
        }

        // Properties
        public double Reel
        {
            get { return _reel; }
            set { _reel = value; }
        }
        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }
        // Methods
        public double CalculeModule()
        {
            return Math.Sqrt(this._reel * this._reel + this._imaginaire * this._imaginaire);
        }
    }
}