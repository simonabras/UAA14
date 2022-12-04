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
            _reel = reel;
            _imaginaire = imaginaire;
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
        public string AfficheComplexe()
        {
            return $"{_reel.ToString("0.00")}, {_imaginaire.ToString("0.00")}";
        }
        public string CalculeModule()
        {
            double module = Math.Sqrt(_reel * _reel + _imaginaire * _imaginaire);
            return $"{module.ToString("0.00")}";
        }
        public void Ajout(double reel, double imaginaire)
        {
            _reel += reel;
            _imaginaire += imaginaire;
        }
    }
}