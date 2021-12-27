using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleForm
{
    public class DikdortgenKutu : Iurun
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int Yukseklik { get; set; }
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }

        public int Hacim()
        {
            return Yukseklik * KisaKenar * UzunKenar;
        }

        public override string ToString()
        {
            return ID + " " + Ad;
        }
    }
}
