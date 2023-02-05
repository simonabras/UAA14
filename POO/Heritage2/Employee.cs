namespace Heritage2
{
    class Employee
    {
        // Protected attributes
        protected int _number;
        protected string _firstname;
        protected string _name;
        protected DateTime _birth_date;

        // Constructor
        public Employee(int number, string firstame, string name, DateTime birthDate)
        {
            _number = number;
            _firstname = firstame;
            _name = name;
            _birth_date = birthDate;
        }

        // Properties
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
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
        // Methods
        public string ShowDetails()
        {
            return $"Monsieur/madame {_firstname} {_name} est né(e) le {_birth_date.ToString("dd/MM/yyyy")} et son matricule est le {_number}";
        }
    }
}