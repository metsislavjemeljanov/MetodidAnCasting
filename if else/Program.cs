namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere kasutaja, sisesta oma kasutajanimi:");
            string kasutajaNimi = Console.ReadLine();
            if (kasutajaNimi != "Nipitiri")
            {
                Console.WriteLine("Sa pole regestrerinud");

            }
            else
            {
                Console.WriteLine("Kas sulle meeldib tulbiud?");
                string vastus = Console.ReadLine();
                if (vastus != "jah")
                {
                    Console.WriteLine("Ei saa kasutajast aru");
                }
                else
                {
                    Console.WriteLine("Mulle kaaa");
                }
                Console.WriteLine("Kasutaja mis on sinu viiimase nädala mängitud tunde?");
                int kell = int.Parse(Console.ReadLine());
                if (kell == 0)
                {
                    Console.WriteLine("kahju et sul aega mängida pole :(");
                }
                else if (kell > 0 && kell < 10)
                {
                    Console.WriteLine("Nõõdukas mängija, tubli");
                }
                else if (kell > 10 && kell < 20)
                {
                    Console.WriteLine("natuke paljuks läheb, kodutööd kannatavad");
                }
                else if (kell > 20 && kell < 40)
                {
                    Console.WriteLine("liiga palju mängid, kas sa kooliks üldse nii jõuad?");
                }
                else if (kell > 40)
                {
                    Console.WriteLine("siin peaks juba sekkuma psühholoog.");
                }

                Console.WriteLine("Kasutaja mis on sinu viimast jälgpallimängu tulemust?");
                int punkti = int.Parse(Console.ReadLine());
                if (punkti == 0)
                {
                    Console.WriteLine("PUDRUJALG OLED VÄ!?!");
                }
                else if (punkti == 1)
                {
                    Console.WriteLine("täitsa ok");
                }
                else if (punkti == 2)
                {
                    Console.WriteLine("no see juba on parem");
                }
                else if (punkti == 3)
                {
                    Console.WriteLine("Wow, messi");
                }
                else if (punkti > 3)
                {
                    Console.WriteLine("Ei tunne sellist skoori, see liga suur minu jaoks");
                }


            }
        }
    }
}
