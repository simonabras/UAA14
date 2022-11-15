namespace REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectMethod utils = new ProjectMethod();
            double[] table = new double[10];
            for(int i=0; i<10; i++)
            {
                table[i] = utils.Read("Entrez un nombre réel");
            }
            double result = utils.Average(table);
            Console.WriteLine(result);
        }
    }
}
