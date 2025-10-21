using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class CFilmato: CElementoMultimediale, IRiproducibile, ILuminosita
    {
        public override string Titolo { get ; set ; }
        public int luminosita { get; set; }
        public int durata { get; set; }
        public int volume { get; set; }

        public CFilmato(string titolo, int volume, int durata)
        {
            Titolo = titolo;
            this.volume = volume;
            luminosita = 5;
            this.durata = durata;
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

        public string uguale(CFilmato other) {

            if (this.durata == other.durata)
            {
                return "i due filmati sono uguali";
            }
            else if (this.durata > other.durata)
            {
                return "il primo filmato è più lungo del secondo";
            }
            else
            {
                return "il secondo filmato è più lungo del primo";
            }
        }

        public string play()
        {
            string rt = "";

            for (int i = 0; i < durata; i++)
            {
                rt += Titolo;
                for (int j = 0; j < volume; j++)
                {
                    rt += "!";
                }

                for (int k = 0; k < luminosita; k++)
                {
                    rt += "*";
                }
                rt += "\n\r";
            }

            return rt;
        }

        public override string ToString()
        {
            return $"filmato: {Titolo}, durata: {durata} minuti, volume attuale {volume}, luminosità attuale {luminosita}";
        }

        public void weaker()
        {
            if (volume <= 20 && volume >= 0)
            {
                volume -= 1;
            }
        }

        public void louder()
        {
            volume += 1;
            if (volume >= 20)
            {
                volume = 20;
            }

            if (volume <= 0)
            {
                volume = 0;
            }
        }

    }
}
