namespace opdracht_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;
            Console.WriteLine("Het dubbele is: " + resultaat);
            Console.ReadLine();

            // Hier wordt het getal wat ingevoerd is (42) verdubbelt met 2 (met een asterisk)
            // en dat is dan het integer resultaat, dat wordt dan in de console aangegeven
            // samen met wat tekst, daarna wordt het opgelezen.
        }
    }
}
