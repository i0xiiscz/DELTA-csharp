namespace uvodni_hodina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zakladni vypis textu
            Console.WriteLine("text");
            Console.Write("text " + 1);

            Console.WriteLine("1+1");
            Console.WriteLine(1 + 1); // nesmi chybet strednik (;)

            // string - text
            string text = "Toto je ukazka textu ve stringu";
            Console.WriteLine(text);
            text = "Upraveny text";
            Console.WriteLine(text);

            // int - cele cislo
            int cislo = 100;
            Console.WriteLine(cislo);
            Console.WriteLine(cislo + 1);
            cislo = 50 * 3;
            Console.WriteLine(cislo);

            // + - scitani
            // - - odcitani
            // * - nasobeni
            // / - deleni

            // bool - true/false
            bool prepinac = false;
            Console.WriteLine(prepinac);
            prepinac = true;
            Console.WriteLine(prepinac);

            // promenna, ktera si bere hodnotu z jine promenne
            int cislo1 = 2;
            int cislo2 = cislo1 + 10;
            Console.WriteLine(cislo2);
        }
    }
}
