namespace Veehoidla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm mis küsib kasutajalt kasutajanime - tsükliga, meetodis

            string kasutajanimi = KasutajaNimi();




            //kui on vale kasutajanimi, programm lõppeb kasutajale teavitamisega
            string correctuser = "siksseven";
            if (kasutajanimi != correctuser)
            {
                Console.WriteLine(kasutajanimi + "programm lõppeb");
            }
            else
            {
                //kui on õige, küsi veetaseme hetkeseisu komakohalise arvuga - tsüklis
                double veetase = 0d;
                Console.WriteLine("Mis on veetaseme hetkeseisu meetrites?");
                bool errorState = false;
                do
                {
                    Console.WriteLine("Mis on veetase anduril?:");
                    double andur = double.Parse(Console.ReadLine());
                    veetase = andur;
                    if (andur > veetase)
                    {
                        errorState = true;
                        break;
                    }


                }
                while (veetase < 1.00d && veetase > 4.25d);
                //kutsu välja eraldi meetod, mille parameetriks on veetase, mis tagastab string-tüüpi andme
                Hoiatussõnum(veetase, errorState);

            }





            //kutsu välja eraldi meetod, mille parameetriks on veetase, mis tagastab string-tüüpi andme
            //meetod kontrollib 3 vahemikku, ja tagastab teavituse põhinedes sellele kui kõrge vesi on
            // vahemik 1: 1-2m tase madal
            // vahemik 2: 2-3.5m tase normaalne
            // vahemik 3: 3.5-4.25m tase kõrge
            // kõik muu annab veateate anduri kohta.


        }

        private static void Hoiatussõnum(double veetase, bool errorState)
        {
            //meetod kontrollib 3 vahemikku, ja tagastab teavituse põhinedes sellele kui kõrge vesi on
            if (veetase >= 1.00d && veetase < 2.00d)
            {
                Console.WriteLine("VEETASE ON MADAL");
            }
            else if (veetase >= 2.0d && veetase < 3.5d)
            {
                Console.WriteLine("Tase normaalne");
            }
            else if (veetase >= 3.5d && veetase < 4.25d)
            {
                Console.WriteLine("tase kõrge");
            }
            else
            {
                errorState = true;
                Console.WriteLine("* anduri viga, kontroli seadet *");
            }



            // vahemik 1: 1-2m tase madal
            // vahemik 2: 2-3.5m tase normaalne
            // vahemik 3: 3.5-4.25m tase kõrge
            // kõik muu annab veateate anduri kohta.
        }


        private static string KasutajaNimi()
        {
            string sisestus = "";
            do
            {
                Console.WriteLine("Tere kasutaja, palun sisesta oma kasutaja nimi");
                sisestus = Console.ReadLine();
            } while (sisestus == "");
            return sisestus;
        }
    }
}
