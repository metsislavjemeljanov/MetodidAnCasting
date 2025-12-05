
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
Console.WriteLine("Tere kasutaja, palun sisesta kasutaja nimi");


Console.WriteLine("Sinu kõihe lemmikuim on: " + lemmikloomad[valik - 1]);
namespace Eelarve_Arvutaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kasutajaNimi = "";
            while (kasutajaNimi == "")
            {
                Console.WriteLine("Tere, sisesta oma nimi:");
                kasutajaNimi = Console.ReadLine();
            }

            string sisestus = "";
            Console.WriteLine("Sisesta tulud ükshaaval, kui on kõikj, siis kirjuta \"rohkem pole\"");
            List<float> tulud = VõtaKasutajaltMituSisenditJärjest();
            List<float> kulud = VõtaKasutajaltMituSisenditJärjest();

            float tuludkokku = 0;
            tuludkokku = ArvutaKokku(tulud);
            float kuludkokku = ArvutaKokku(kulud);


            float kooku = (float)Math.Round((tuludkokku - kuludkokku),2);
            Console.WriteLine($"Kasutaja: {kasutajaNimi}, teie kontoseis on: {kokku}");
        }

        private static float ArvutaKokku(List<float> tulud)
        {
            float kokku = 0;
            for (int i = 0; i < tulud.Count; i++)
            {
                kokku += tulud[i];
            }

            return kokku;
        }

        private static List<float> VõtaKasutajaltMituSisenditJärjest()
        {
            string sisestus = "";
            List<float> tulud = new List<float>();
            do
            {
                Console.WriteLine("Sisesta oma tulud /ÜKSHAAVAL* - järgmine sisestus:");
                sisestus += Console.ReadLine();
                if (sisestus == "rohkem pole")
                {
                    break;
                }
                float conversion = float.Parse(sisestus);
                tulud.Add(conversion);
            } while (sisestus != "rohkem pole");
            return tulud;
        }   
    }
}
