namespace knp_s_polem_reseni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pole s hodnotami
            string[] knp = { "kamen", "nuzky", "papir" };
            // generator a pomocna promenna
            Random generator = new Random();
            int skore = 0;
            bool play_again = true;

            while(play_again == true)
            {
                int bot = 0;
                string hrac = "";
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Tve skore je: {skore}");
                    Console.Write("Napis, co chces zahrat (kamen/nuzky/papir: ");
                    hrac = Console.ReadLine();
                } while (hrac!="papir"|| hrac != "kamen"|| hrac != "nuzky");

                bot = generator.Next(0, 3);

                if ((knp[bot] == "kamen" && hrac == "nuzky") ||
                    (knp[bot] == "nuzky" && hrac == "papir") ||
                    (knp[bot] == "papir" && hrac == "kamen"))
                {
                    Console.WriteLine($"Prohral jsi\n" +
                        $"BOT vybral {knp[bot]}\n" +
                        $"ty jsi vybral {hrac}");
                    skore--;
                }
                else if ((knp[bot] == "nuzky" && hrac == "kamen") ||
                    (knp[bot] == "papir" && hrac == "nuzky") ||
                    (knp[bot] == "kamen" && hrac == "papir"))
                {
                    Console.WriteLine($"Vyhral jsi\n" +
                        $"BOT vybral {knp[bot]}\n" +
                        $"ty jsi vybral {hrac}");
                    skore++;
                }
                else
                {
                    Console.WriteLine($"Hra skoncila remizou\n" +
                        $"BOT vybral {knp[bot]}\n" +
                        $"ty jsi vybral {hrac}");
                }
            }            
        }
    }
}
