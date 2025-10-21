using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CElementoMultimediale> elementi = new List<CElementoMultimediale>();

            elementi.Add(new CImmagine("Foto Vacanza"));
            elementi.Add(new CFilmato("Video Compleanno", 5, 3));
            elementi.Add(new CRegistrazioneAudio("Audio Lezione", 4, 7));
            elementi.Add(new CImmagine("Foto Matrimonio"));
            elementi.Add(new CFilmato("Video Viaggio", 3, 2));

            int scelta;

            do
            {
                WriteLine("cosa vuoi fare? 1) eseguire un elemento 2) modificare i parametri 3) filtrare i film per orario " +
                    "4) ordinare elementi in ordine alfabetico 5) determinare se 2 film sono uguali");
            } while (!Int32.TryParse(ReadLine(), out scelta));

            switch(scelta)
            {
                case 1:
                    RiproduciElemento();
                break;

                case 2:
                    modificaParametri();
                    break;

                case 3:
                    filtrafilmperdurata();
                    break;

                case 4:
                    ordinaelementiordinealfabetico();
                    break;

                case 5:
                    determinafilmuguali();
                    break;

                default:
                    WriteLine("scelta non valida");
                break;
            }

            void ordinaelementiordinealfabetico()
            {
                for (int i = 0; i < elementi.Count - 1; i++)
                {
                    for (int j = 0; j < elementi.Count - i - 1; j++)
                    {
                        if (elementi[j].Titolo == elementi[j + 1].Titolo)
                        {
                            CElementoMultimediale temp = elementi[j];
                            elementi[j] = elementi[j + 1];
                            elementi[j + 1] = temp;
                        }
                    }
                }
            }

            void determinafilmuguali()
            {
                for(int i = 0; i < 5; i++)
                {
                    if(elementi[i] is CFilmato filmato1)
                    {
                        for(int j = i + 1; j < 5; j++)
                        {
                            if(elementi[j] is CFilmato filmato2)
                            {
                                filmato2.uguale(filmato1);
                            }
                        }
                    }
                }
            }

            void filtrafilmperdurata()
            {
                int durataMax;

                do
                {
                    WriteLine("inserisci la durata massima dei filmati da filtrare:");
                } while (!Int32.TryParse(ReadLine(), out durataMax));

                for(int i = 0; i < 5; i++)
                {
                    if (elementi[i] is CFilmato cfilmato)
                    {
                        if(cfilmato.durata <= durataMax)
                        {
                            WriteLine(cfilmato.ToString());
                        }
                    }
                }
            }

            void modificaParametri()
            {
                int s;
                do
                {
                    WriteLine("quale elemento vuoi modificare? 1) foto vacanza 2) video compleanno 3) audio lezione 4) foto matrimo 5) video viaggio");
                } while (!Int32.TryParse(ReadLine(), out s));

                switch (s)
                {
                    case 1:
                        CImmagine img1 = (CImmagine)elementi[0];
                        img1.brighter();
                        WriteLine(img1.ToString());
                        break;
                    case 2:
                        CFilmato vid1 = (CFilmato)elementi[1];
                        vid1.louder();
                        WriteLine(vid1.ToString());
                        break;
                    case 3:
                        CRegistrazioneAudio aud1 = (CRegistrazioneAudio)elementi[2];
                        aud1.weaker();
                        WriteLine(aud1.ToString());
                        break;
                    case 4:
                        CImmagine img2 = (CImmagine)elementi[3];
                        img2.darker();
                        WriteLine(img2.ToString());
                        break;
                    case 5:
                        CFilmato vid2 = (CFilmato)elementi[4];
                        vid2.brighter();
                        WriteLine(vid2.ToString());
                        break;
                    default:
                        WriteLine("scelta non valida");
                        break;
                }

            }

            void RiproduciElemento()
            {
                int s;
                do
                {
                    WriteLine("che elemento devo ripordurre? 1) foto vacanza 2) video compleanno 3) audio lezione 4) foto matrimo 5) video viaggio");
                }
                while (!Int32.TryParse(ReadLine(), out s));

                switch (s)
                {
                    case 1:
                        CImmagine img1 = (CImmagine)elementi[0];
                        WriteLine(img1.show());
                        break;

                    case 2:
                        CFilmato vid1 = (CFilmato)elementi[1];
                        WriteLine(vid1.play());
                        break;

                    case 3:
                        CRegistrazioneAudio aud1 = (CRegistrazioneAudio)elementi[2];
                        WriteLine(aud1.play());
                        break;

                    case 4:
                        CImmagine img2 = (CImmagine)elementi[3];
                        WriteLine(img2.show());
                        break;

                    case 5:
                        CFilmato vid2 = (CFilmato)elementi[4];
                        WriteLine(vid2.play());
                        break;

                    default:
                        WriteLine("scelta non valida");
                        break;
                }
            }
            
        }
    }
}
