namespace Heritage2
{
    class Director : Employee
    {
        // Private attributes
        private double _turnover;
        private double _percentage;

        // Constructor
        public Director(int number, string firstame, string name, DateTime birthDate, double turnover, double percentage) : base (number, firstame, name, birthDate)
        {
            _number = number;
            _firstname = firstame;
            _name = name;
            _birth_date = birthDate;
            _turnover = turnover;
            _percentage = percentage;
        }

        // Properties
        public double Turnover
        {
            get { return _turnover; }
            set { _turnover = value; }
        }
        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }
        // Methods
        public double CalculSalary()
        {
            return _turnover * _percentage;
        }
    }
}