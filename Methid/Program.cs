using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        NewMessage();
        List<string> ostunimekiri = new List<string>();
        Console.WriteLine("Sisesta oma tänane peskäigunimekiri");
        string kasutajaSisestus = "";
        GetUserInput(kasutajaSisestus, ostunimekiri);
        foreach (var söök in ostunimekiri)
        {
            Console.WriteLine($" -*- {söök}");
        }
        GetUserInput(kasutajaSisestus, ostunimekiri);

    }

    static List<string> GetUserInput(string kasutajasisestus, List<string> ostunimekiri)
    {
        while (kasutajasisestus != "rohkem pole")
        {
            Console.WriteLine("Kirjuta ükshvaal, sisesta järgmine ost:\nKui ei ole midagi lisada, siis ütle \"rohke, pole\"");
            kasutajasisestus = Console.ReadLine();
            if (kasutajasisestus != "" || kasutajasisestus != "rohkem pole")
            {
                ostunimekiri.Add(kasutajasisestus);
            }
            else if (kasutajasisestus == "rohkem pole")
            {
                kasutajasisestus = "";
            }
        }
        Console.WriteLine("see sinu nimekiri");
        return ostunimekiri;
    }

    static void NewMessage()
    {
        Console.WriteLine("this is a message");
    }
}