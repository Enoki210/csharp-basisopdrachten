namespace eersteles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Molecule";
            int age = 10;
            int howold;

            howold = 6;

            age = age + 10;
            age += 20;
            age += howold;


            Console.WriteLine($"Hallo Buurman {name}");
            Console.WriteLine($"{age}");
        }
    }
}
