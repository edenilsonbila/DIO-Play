using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Play.Service;

namespace DIO_Play.Classes
{
	public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> lista = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            lista[id] = objeto;
        }

        public Serie Find(int id)
        {
            return lista[id];
        }

        public void Exclui(int id)
        {
            lista[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            lista.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return lista;
        }

        public int ProximoId()
        {
            return lista.Count;
        }
    }
}
