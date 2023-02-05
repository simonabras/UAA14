namespace Heritage2
{
    class Worker : Employee
    {
        // Private attributes
        private DateTime _entry_date;

        // Constructor
        public Worker(int number, string firstame, string name, DateTime birthDate, DateTime entryDate) : base (number, firstame, name, birthDate)
        {
            _number = number;
            _firstname = firstame;
            _name = name;
            _birth_date = birthDate;
            _entry_date = entryDate;
        }

        // Properties
        public DateTime EntryDate
        {
            get { return _entry_date; }
            set { _entry_date = value; }
        }
        // Methods
        public int CalculSalary()
        {
            int fix = 2500; // Partie fixe
            int seniority = DateTime.Now.Year - _entry_date.Year; // Ancienneté en année
            return fix + (seniority * 100);
        }
    }
}