using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Play.Service;

namespace DIO_Play.Classes
{
	public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> lista = new List<Filme>();

        public void Atualiza(int id, Filme objeto)
        {
            lista[id] = objeto;
        }

        public Filme Find(int id)
        {
            return lista[id];
        }

        public void Exclui(int id)
        {
            lista[id].Excluir();
        }

        public void Insere(Filme objeto)
        {
            lista.Add(objeto);
        }

        public List<Filme> Lista()
        {
            return lista;
        }

        public int ProximoId()
        {
            return lista.Count;
        }
    }
}
