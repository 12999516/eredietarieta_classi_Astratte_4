using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal interface IRiproducibile
    {
        int volume { get; set; }

        int durata { get; set; }

        void weaker();
        void louder();

        string play();
    }
}
