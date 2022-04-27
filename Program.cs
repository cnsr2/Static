class program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calısan Sayısı : "+ Calısan.CalisanSayisi);
        Calısan calisan1 = new Calısan("Emre Can","Sarı","Barista");   
        Console.WriteLine("Calısan Sayısı : "+ Calısan.CalisanSayisi);
        Calısan calisan2 = new Calısan("Kaan","Berk","Garson");
        Console.WriteLine("Calısan Sayısı : "+ Calısan.CalisanSayisi);
        Islemler.topla(3,5);
        Islemler.cıkar(5,3);
        Console.WriteLine(Islemler.topla(3,5));
        Console.WriteLine(Islemler.cıkar(5,3));
    }
}
class Calısan
{
    private static int calisanSayisi;
    public static int CalisanSayisi{ get => calisanSayisi;}
    private string Isim;
    private string Soyisim;
    private string Departman;
    static Calısan()
    {
        calisanSayisi = 0 ;
    }
    public Calısan(string isim,string soyisim,string departman)
    {
        Isim = isim;
        Soyisim = soyisim;
        Departman = departman;
        calisanSayisi ++;
    }
}
static class Islemler
    {
        public static long topla(int a, int b)
        {
            return a+b;
        } 
        public static long cıkar(int a, int b)
        {
            return a-b;
        } 
    }