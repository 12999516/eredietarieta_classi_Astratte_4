using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class CImmagine:CElementoMultimediale, ILuminosita
    {
        public override string Titolo { get; set; }
        public int luminosita { get; set; }

        public CImmagine(string titolo)
        {
            Titolo = titolo;
            luminosita = 5;
        }

        public void darker()
        {
            if (luminosita <= 10 && luminosita >= 0)
            {
                luminosita -= 1;
            }
        }

        public void brighter()
        {
            luminosita += 1;
            if (luminosita >= 10)
            {
                luminosita = 10;
            }
            if (luminosita <= 0)
            {
                luminosita = 0;
            }
        }

        public override string ToString()
        {
            return $"immagine: {Titolo}, luminosità attuale {luminosita}";
        }

        public string show()
        {
            string rt = "";
            for (int i = 0; i < luminosita; i++)
            {
                rt += Titolo;
                for (int j = 0; j < luminosita; j++)
                {
                    rt += "*";
                }
            }
            return rt;
        }
    }
}
