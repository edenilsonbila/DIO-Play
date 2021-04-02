using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Play.Service
{
    interface IRepositorio<T>
    {
        List<T> Lista();

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        T Find(int id);

        int ProximoId();
    }
}
