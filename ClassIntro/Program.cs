
class Program
{
    static void Main(string[] args)
    {
        string adi = "Mert";
        int yas = 22;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Mert";
        kurs1.IzlenmeOrani = "68";

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Python";
        kurs2.Egitmen = "Nico";
        kurs2.IzlenmeOrani = "31";

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Enjineer";
        kurs3.Egitmen = "Engin";
        kurs3.IzlenmeOrani = "69";

        // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
        }

    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public string IzlenmeOrani { get; set; }


}
