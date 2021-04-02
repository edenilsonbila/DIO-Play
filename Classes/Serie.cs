using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Play.Interfaces;

namespace DIO_Play.Classes
{
    public class Serie : Media
    {
        private int Episodios { get; set; }

        public Serie(double imdb, int duracao, DateTime dataLancamento, int episodios) : base(imdb, duracao, dataLancamento)
        {
            Episodios = episodios;
        }

        public override string ToString()
        {
            return $" {Episodios} {Ano} {Titulo}";
        }


        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}
