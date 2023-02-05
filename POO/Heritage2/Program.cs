namespace Heritage2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voici la liste des employés :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int number = 0;
            Worker[] workers = new Worker[5];
            for(int i=0; i < workers.Length; i++)
            {
                number++;
                workers[i] = new Worker(number, "prénom", "nom", new DateTime(1870, 12, 15), new DateTime(1890, 10, 1));
                Console.WriteLine(workers[i].ShowDetails());
                Console.WriteLine($"Salaire : {workers[i].CalculSalary()} écus");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Executive[] executives = new Executive[3];
            for(int i=0; i < executives.Length; i++)
            {
                number++;
                executives[i] = new Executive(number, "prénom", "nom", new DateTime(1870, 12, 15), 2);
                Console.WriteLine(executives[i].ShowDetails());
                Console.WriteLine($"Salaire : {executives[i].CalculSalary()} écus");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Director[] directors = new Director[3];
            for(int i=0; i < directors.Length; i++)
            {
                number++;
                directors[i] = new Director(number, "prénom", "nom", new DateTime(1870, 12, 15), 75000, 0.25);
                Console.WriteLine(directors[i].ShowDetails());
                Console.WriteLine($"Salaire : {directors[i].CalculSalary()} écus");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
    }
}