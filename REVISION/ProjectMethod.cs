namespace REVISION
{
    public struct ProjectMethod
    {
        public double Read(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            double number;
            while(!double.TryParse(response, out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Merci d'entrer un réel");
                Console.ForegroundColor = ConsoleColor.White;
                response = Console.ReadLine();
            }
            return number;
        }

        public double Average(double[] table)
        {
            double result = 0;
            for(int i=0; i<table.Length; i++)
            {
                result += table[i];
            }
            result /= table.Length;
            return result;
        }
    }
}