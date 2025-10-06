namespace podminky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vyzveme uzivatele k zadani cisla
            Console.WriteLine("Napis cislo a ja zkontroluji, zda plati nejaka z podminek");
            int podminka = int.Parse(Console.ReadLine());

            // pokud se cislo rovna 0, je splnena podminka a zbytek preskocime
            // pokud se cislo nerovna 0, preskakujeme a jdeme na dalsi podminku
            if (podminka == 0)
            {
                Console.WriteLine("Cislo je presne 0");
            }
            // pokud je cislo mensi nez 2, je splnena podminka a zbytek preskocime
            // pokud je cislo vetsi nez 2, preskakujeme a jdeme na dalsi podminku
            else if (podminka < 2)
            {
                Console.WriteLine("Podminka byla splnena");
            }
            // pokud jsme se dostali az sem, vypada to, ze zadna podminka nebyla splnena
            // vykoname akci, ktera se stane pokud se zadna predtim neprovedla
            else
            {
                Console.WriteLine("Podminka nebyla splnena, zkus to znovu");
            }

            // podminky s textem
            string pismeno = Console.ReadLine();
            if (pismeno == "a") // pro porovnani textu musime mit porovnavany text v uvozovkach
            {
                Console.WriteLine("aaa");
            }
        }
    }
}
