using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleForm
{
    public class KupKutu : Iurun
    {
        public int ID {get;set;}
        public string Ad { get;set;}
        public int Yukseklik { get;set;}


        public int Hacim()
        {

            return Convert.ToInt32(Math.Pow(Convert.ToDouble(Yukseklik), 3));
        }
        public override string ToString()
        {
            return ID + " " + Ad;
        }
    }
}
