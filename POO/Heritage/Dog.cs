namespace Heritage
{
    class Dog : Animal
    {
        public Dog(string name, DateTime birth_date, int number, int size, bool competition) : base (name, birth_date, number, size, competition)
        {
            _name = name;
            _birth_date = birth_date;
            _number = number;
            _size = size;
            _competition = competition;
        }
        // Methods
        public string Bark()
        {
            return $"{_name} vient d'aboyer !";
        }
    }
}