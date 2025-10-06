namespace cteni_z_konzole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine(); - cteni z konzole
            Console.WriteLine("Zadej svoje jmeno:");
            string cteni = Console.ReadLine();
            Console.WriteLine($"Ahoj, moje jmeno je {cteni}");

            // double - desetinne cislo
            double desetiny = 2.1;
            Console.WriteLine(desetiny / 2);

            // prevedeni textu na cislo pomoci double.Parse();
            double cislo = double.Parse(Console.ReadLine());
            Console.WriteLine(cislo);
        }
    }
}