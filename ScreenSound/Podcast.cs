using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Podcast
    {
        List<Episodio> episodios = new List<Episodio>();

        public string Nome { get; }
        public string Host { get; }
        public int TotalEpisodios => episodios.Count;


        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public void AdicionarEpisodio (Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {Nome} apresentado por {Host}.\n");

            foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios.");
        }
    }
}
