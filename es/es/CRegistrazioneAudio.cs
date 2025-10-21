using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class CRegistrazioneAudio: CElementoMultimediale, IRiproducibile
    {
        public override string Titolo { get; set; }
        public int durata { get; set; }

        public int volume { get; set; }
        public CRegistrazioneAudio(string titolo, int durata, int volume)
        {
            Titolo = titolo;
            this.durata = durata;
            this.volume = volume;
        }

        public override string ToString()
        {
            return $"registrazione: {Titolo}, durata: {durata} minuti, volume attuale {volume}";
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
                rt += "\n\r";
            }
            return rt;
        }

        public void weaker()
        {
            if(volume <= 20 && volume >= 0)
            {
                volume -= 1;
            }
        }

        public void louder()
        {
            volume += 1;
            if(volume >= 20)
            {
                volume = 10;
            }

            if(volume <= 0)
            {
                volume = 0;
            }
        }
    }
}
