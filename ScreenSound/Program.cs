using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Episodio ep1 = new Episodio(2, "Técnicas de Facilitação", 45);
            ep1.AdicionarConvidados("Maria");
            ep1.AdicionarConvidados("Marcelo");
            

            Episodio ep2 = new Episodio(1, "Técnicas de Aprendizado", 67);
            ep2.AdicionarConvidados("Fernando");
            ep2.AdicionarConvidados("Marcos");


            Episodio ep3 = new Episodio(3, "Técnicas de Ensino", 56);
            ep3.AdicionarConvidados("João");
            ep3.AdicionarConvidados("Luíza");

        
            Podcast podcast = new Podcast("Fellas", "Esdras");
            podcast.AdicionarEpisodio(ep1);
            podcast.AdicionarEpisodio(ep2);
            podcast.AdicionarEpisodio(ep3);

            podcast.ExibirDetalhes();



            //Album albumDoQueen = new Album("A night at the opera");

            //Banda queen = new Banda("queen");


            //Musica musica1 = new Musica("Love of my life", queen, true)
            //{
            //    Duracao = 213
            //};


            //Musica musica2 = new Musica("Bohemian Rhapsody", queen, true)
            //{
            //    Duracao = 364
            //};


            //albumDoQueen.AdicionarMusica(musica1);
            //albumDoQueen.AdicionarMusica(musica2);
            //queen.AdicionarAlbum(albumDoQueen);

            //musica1.ExibirFichaTecnica();
            //musica2.ExibirFichaTecnica();
            //albumDoQueen.ExibirMusicasDoAlbum();
            //queen.ExibirDiscografia();



            //int Somar(int a, int b) => a + b;
            //Console.WriteLine(Somar(1, 2));


        }

    }
}
