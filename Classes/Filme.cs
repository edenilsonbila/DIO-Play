using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Play.Interfaces;

namespace DIO_Play.Classes
{
    public class Filme : Media
    {
        public Filme(double imdb, double duracao, DateTime dataLancamento) : base(imdb, duracao, dataLancamento)
        {
        }

        public override string ToString()
        {
            return $"{Ano} {Titulo}";
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
