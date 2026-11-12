namespace opdracht_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string een = "Welkom bij C#";
            // Dit is string omdat het tekst is, geen cijfer
            short twee = 260;
            // Dit is een short omdat het een klein getal tussen de -32.767 en 32.767 is
            short drie = -56;
            // Hetzelfde geldt hier als bij de bovenste
            double vier = 2001.99;
            // Dit is een double omdat er een decimaal staat in het getal
            string vijf = "k1ngd0m";
            // Hier zou je nog steeds een string kunnen gebruiken want de getallen maken onderdeel van de tekst

            Console.WriteLine($"{een}");
            Console.WriteLine($"{twee}");
            Console.WriteLine($"{drie}");
            Console.WriteLine($"{vier}");
            Console.WriteLine($"{vijf}");
        }
    }
}
