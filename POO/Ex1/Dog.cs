namespace Ex1
{
    class Dog
    {
        // Private attributes
        private string _name;
        private string _race;
        private uint _age;

        // Constructor
        public Dog(string name, string race, uint age)
        {
            this._name = name;
            this._race = race;
            this._age = age;
        }

        // Propriétés
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }
        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string ShowDetails()
        {
            return $"Name: {this._name} | Race: {this._race} | Age: {this._age}";
        }
    }
}