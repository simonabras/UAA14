namespace Heritage
{
    class Rabbit : Animal
    {
        // Private attributes
        private int _earsSize;

        // Constructor
        public Rabbit(string name, DateTime birth_date, int number, int size, bool competition, int earsSize) : base (name, birth_date, number, size, competition)
        {
            _name = name;
            _birth_date = birth_date;
            _number = number;
            _size = size;
            _competition = competition;
            _earsSize = earsSize;
        }

        // Properties
        public int EarsSize
        {
            get { return _earsSize; }
            set { _earsSize = value; }
        }
        // Methods
        public string Jump()
        {
            Random number = new Random();
            int height = number.Next(1, 3);
            return $"{_name} vient de faire un saut de {height}m de hauteur !";
        }
    }
}