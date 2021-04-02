using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Play.Enums;
using DIO_Play.Interfaces;

namespace DIO_Play.Classes
{
    public abstract class Media : IMedia
    {
        protected Media(double imdb, double duracao, DateTime dataLancamento)
        {
            DataCadastro = DateTime.Now;
            Imdb = imdb;
            Duracao = duracao;
            DataLancamento = dataLancamento;
            Ano = ObtemAnoLancamento();
        }

        public Genero Genero { get; set; }
        protected string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; }
        public bool Excluido { get; set; }

        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataExclusao { get; set; }

        public DateTime DataLancamento { get; set; }

        public double Imdb { get; set; }

        public Diretor Diretor { get; set; }

        public double Duracao { get; set; }

        public void Play()
        {
          Console.WriteLine("Em execução!");
        }

        public void Pause()
        {
            Console.WriteLine("Pasado!");
        }

        public void Avancar(int tempo)
        {
            Console.WriteLine("Avançou " + tempo);
        }

        public void Retroceder(int tempo)
        {
            Console.WriteLine("Retrocedeu "+ tempo);
        }

        public void Excluir()
        {
            this.DataExclusao = DateTime.Now;
        }

        private int ObtemAnoLancamento()
        {
            return DataLancamento.Year;
        }
    }
}
