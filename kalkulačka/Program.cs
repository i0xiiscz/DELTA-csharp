namespace kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej prvni cislo:");
            double cislo1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadej druhe cislo:");
            double cislo2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(cislo1 + cislo2);
            Console.WriteLine(cislo1 - cislo2);
            Console.WriteLine(cislo1 * cislo2);
            Console.WriteLine(cislo1 / cislo2);
        }
    }
}