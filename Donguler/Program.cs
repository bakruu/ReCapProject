

class Program
{
    static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetişrime Kampı";
        string kurs2 = "Programlamaya başlangıç için temel kurs";
        string kurs3 = "java";

        //array - dizi

        string[] kurslar = new string[] { "Yazılım Geliştirici Yetişrime Kampı", "Programlamaya başlangıç için temel kurs", "java" }; 

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        // For veya Foreachg Farkı


        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("sayfa sonu - footer");
    }
}
