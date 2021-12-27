using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleForm
{
    public interface Iurun
    {
        int ID { get; set; }
        string Ad { get; set; }
        int Yukseklik { get; set; }
        int Hacim();
    }
}
