using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciSinifi ogrenci = new OgrenciSinifi();
            ogrenci.Sinifi = "10B";
            ogrenci.Numarasi = 33;
            ogrenci.Adi = "EfeKaan";
            ogrenci.SoyAdi = "Dokumaci";
            ogrenci.TcKimlikNo = 23536969474;
            ogrenci.DiplomaNotu = 24.5;
           Console.WriteLine("OGRENCİ SINIFI:"+ ogrenci.Sinifi);
           Console.WriteLine("OGRENCİ Numarası:" + ogrenci.Numarasi);
           Console.WriteLine("OGRENCİ Adı:" + ogrenci.Adi);
           Console.WriteLine("OGRENCİ Soy Adi:" + ogrenci.SoyAdi);
           Console.WriteLine("OGRENCİ TCKİMLİKNO:" + ogrenci.TcKimlikNo);
           Console.WriteLine("OGRENCİ Diploma Notu:" + ogrenci.DiplomaNotu);





            BilgisayarSinifi bilgisayar = new BilgisayarSinifi();
            bilgisayar.AnaKart = "Lenovo";
            bilgisayar.İslemci = "Intel I9";
            bilgisayar.Ram = 64;
            bilgisayar.SSD = "1TB";
            bilgisayar.Kasa = "Lenovo";
            bilgisayar.Ekran = "Casper";
            bilgisayar.Klavye = "Logitech";
            bilgisayar.Mouse = "Msi Clutch GM08";
            Console.WriteLine("BİLGİSİYAR ANAKART:"+bilgisayar.AnaKart);
            Console.WriteLine("BİLGİSİYAR İSLEMCİ:" + bilgisayar.İslemci);
            Console.WriteLine("BİLGİSİYAR RAM:" + bilgisayar.Ram);
            Console.WriteLine("BİLGİSİYAR SSD:" + bilgisayar.SSD);
            Console.WriteLine("BİLGİSİYAR KASA:" + bilgisayar.Kasa);
            Console.WriteLine("BİLGİSİYAR EKRAN:" + bilgisayar.Ekran);
            Console.WriteLine("BİLGİSİYAR KLAVYE:" + bilgisayar.Klavye);
            Console.WriteLine("BİLGİSİYAR MOUSE:" + bilgisayar.Mouse);

        }
    }
   public class OgrenciSinifi
    {
        public string Sinifi;
        public uint Numarasi;
        public string Adi;
        public string SoyAdi;
        public ulong TcKimlikNo;
        public double DiplomaNotu;

    }
    public class BilgisayarSinifi
    {
        public string AnaKart;
        public string İslemci;
        public short Ram;
        public string SSD;
        public string Kasa;
        public string Ekran;
        public string Klavye;
        public string Mouse;

    }
        


}
