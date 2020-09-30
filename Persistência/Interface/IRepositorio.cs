using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.Interface
{
    public interface IRepositorio<T> where T : class
    {
        void Adicionar(T item);
        void Remover(T item);
        void Editar(T item);
        T ObtemPorId(object id);
        IQueryable<T> Tudo();
    }
}
