using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal interface ILuminosita
    {
        int luminosita { get; set; }
        void darker();
        void brighter();
    }
}
