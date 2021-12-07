using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ParticalClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri M1 = new musteri();
            M1.id = 1;
            M1.isim = "Emre";
            M1.soyisim = "Gemici";
            M1.emailAdres = "emregemici@gmail.com";

            int sonuc = M1.yeniKayit(M1);
            if (sonuc >0)
            {
                Console.WriteLine("Database yeni kayıt eklendi.");
            }

            ogrenci O1 = new ogrenci();
            O1.id = 1;
            int ogrenciKayitSonuc = O1.yeniKayit(O1);

            if (ogrenciKayitSonuc ==71777000)
            {

            }

            else if (ogrenciKayitSonuc == 71777001)
            {

            }
            else if (ogrenciKayitSonuc == 71777002)
            {

            }

            else if (ogrenciKayitSonuc == 71777003)
            {

            }
            else if (ogrenciKayitSonuc == 71777004)
            {

            }

        }
    }
}
