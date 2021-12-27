using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleConsole
{
    public class Musteri : Imusteri,Ideneme
    {
        private int _id;
        public int ID { get { return _id; } set { _id = value; }  }
        private string _ad;
        public string Ad { get { return _ad; } set { _ad = value; } }
        private string _soyad;
        public string Soyad { get { return _soyad; } set { _soyad = value; } }

        public int denemeNo { get; set; }

        public int KayitDuzenle(int id, string isim, string soyisim)
        {
            ID = id;
            Ad = isim;
            Soyad = soyisim;
            Console.WriteLine("Kayıt Düzenlendi!");
            return ID;
        }

        public int YeniKayit(string isim, string soyisim)
        {
            ID = 2;
            Ad = isim;
            Soyad = soyisim;

            Console.WriteLine("Kayıt Eklendi!");
            return ID;
        }

        public int denemeMethod()
        {
            return 1;
        }
    }
}
