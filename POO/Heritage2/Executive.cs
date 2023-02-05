namespace Heritage2
{
    class Executive : Employee
    {
        // Private attributes
        private int _salary_index;

        // Constructor
        public Executive(int number, string firstame, string name, DateTime birthDate, int salaryIndex) : base (number, firstame, name, birthDate)
        {
            _number = number;
            _firstname = firstame;
            _name = name;
            _birth_date = birthDate;
            _salary_index = salaryIndex;
        }

        // Properties
        public int SalaryIndex
        {
            get { return _salary_index; }
            set { _salary_index = value; }
        }

        // Methods
        public int CalculSalary()
        {
            int[] salaries = { 13000, 15000, 17000, 20000 }; // Différents salaires en fonction de l'index
            return salaries[_salary_index];
        }
    }
}