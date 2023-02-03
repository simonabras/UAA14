namespace Heritage
{
    class Cat : Animal
    {
        public Cat(string name, DateTime birth_date, int number, int size, bool competition) : base (name, birth_date, number, size, competition)
        {
            _name = name;
            _birth_date = birth_date;
            _number = number;
            _size = size;
            _competition = competition;
        }
        // Methods
        public string Meow()
        {
            return $"{_name} vient de miauler !";
        }
        public string Purr()
        {
            return $"{_name} vient de ronronner !";
        }
    }
}