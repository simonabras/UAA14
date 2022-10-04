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

        public string ShowDetails()
        {
            return $"Name: {this._name} | Race: {this._race} | Age: {this._age}";
        }
    }
}