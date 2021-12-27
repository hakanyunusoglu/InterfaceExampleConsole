using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleConsole
{
    public interface Imusteri
    {
        //public Imusteri()
        //{
              //Interface' de yapıcı method kullanılmaz. Tamamen şablondur  
              //Field'lar yer alır
        //}

        int ID { get; set; }
        // Erişim belirleyicisi kullanılamaz (public,private,protected vb.)
        string Ad { get; set; }
        string Soyad { get; set; }

        int YeniKayit(string isim, string soyisim);
        int KayitDuzenle(int id, string isim, string soyisim);

        //Değişken tanımlanamaz, sadece property oluşturulabilir.
        //Interface new'lenemez, örneklenmez. Bkz. Imusteri() im = new Imusteri(); gibi örneklenemez.
        //Classlar 1 den fazla interface'den miras alabilir.
    }
}
