namespace Heritage
{
    class Animal
    {
        // Private attributes
        protected string _name;
        protected DateTime _birth_date;
        protected int _number;
        protected int _size;
        protected bool _competition;

        // Constructor
        public Animal(string name, DateTime birth_date, int number, int size, bool competition)
        {
            _name = name;
            _birth_date = birth_date;
            _number = number;
            _size = size;
            _competition = competition;
        }

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime BirthDate
        {
            get { return _birth_date; }
            set { _birth_date = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public bool Competition
        {
            get { return _competition; }
            set { _competition = value; }
        }
        // Methods
        public string Eat()
        {
            return $"{_name} vient de manger !";
        }
        public string Sleep()
        {
            Random number = new Random();
            int hours = number.Next(2, 6);
            return $"{_name} vient de faire une sieste de {hours} heures !";
        }
    }
}