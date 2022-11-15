namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre chenil");
            Dog[] dogs = new Dog[3];
            for(int i=0; i<dogs.Length; i++)
            {
                Console.WriteLine("Quel est le nom de votre chien ?");
                string dogName = Console.ReadLine();
                Console.WriteLine("Quelle est la race de votre chien ?");
                string dogRace = Console.ReadLine();
                Console.WriteLine("Quel est l'âge de votre chien ?");
                uint dogAge = uint.Parse(Console.ReadLine());

                dogs[i] = new Dog(dogName, dogRace, dogAge);
                Console.WriteLine(dogs[i].ShowDetails());
                if(i < 2)
                {
                    dogs[i].Age += 2;
                }
            }
            Console.WriteLine("-----------");
            uint average = 0;
            for(int i=0; i<dogs.Length; i++)
            {
                Console.WriteLine(dogs[i].ShowDetails());
                average += dogs[i].Age;
            }
            average /= (uint)(dogs.Length);
            Console.WriteLine($"Moyenne des âges : {average}");
        }
    }
}