using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; }
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
        

        public Musica()
        {
        }

        public Musica(string nome, Banda artista, bool disponivel)
        {
            Nome = nome;
            Artista = artista;
            Disponivel = disponivel;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel) Console.WriteLine("Disponível no plano.\n");
            else Console.WriteLine("Adquira o plano Plus+.\n");
        }

    }
}
