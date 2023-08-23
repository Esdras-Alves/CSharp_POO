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
            Album albumDoQueen = new Album("A night at the opera");

            Banda queen = new Banda("queen");


            Musica musica1 = new Musica("Love of my life", queen, true)
            {
                Duracao = 213
            };


            Musica musica2 = new Musica("Bohemian Rhapsody", queen, true)
            {
                Duracao = 364
            };
        

            albumDoQueen.AdicionarMusica(musica1);
            albumDoQueen.AdicionarMusica(musica2);
            queen.AdicionarAlbum(albumDoQueen);

            musica1.ExibirFichaTecnica();
            musica2.ExibirFichaTecnica();
            albumDoQueen.ExibirMusicasDoAlbum();
            queen.ExibirDiscografia();






            //int Somar(int a, int b) => a + b;
            //Console.WriteLine(Somar(1, 2));


        }

    }
}
