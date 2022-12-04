namespace Ex3
{
    class Personne
    {
        // Private attributes
        private string _name;
        private int _money;

        // Constructor
        public Personne(string name, int money)
        {
            _name = name;
            _money = money;
        }

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
        // Methods
        public void AddMoney(int money)
        {
            _money += money;
        }
        public void RemoveMoney(int money)
        {
            _money -= money;
        }
        public string AffichePersonne()
        {
            return $"{_name} a {_money}€ sur son compte";
        }
    }
}