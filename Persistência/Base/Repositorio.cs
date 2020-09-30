using Persistência.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.Base
{
    public class Repositorio<T> : IDisposable, IRepositorio<T> where T : class
    {
        protected readonly DbContext contexto;
        public Repositorio(DbContext contexto)
        {
            this.contexto = contexto;
        }
        public virtual void Adicionar(T item)
        {
            contexto.Set<T>().Add(item);
            contexto.SaveChanges();
        }

        public virtual void Remover(T item)
        {
            contexto.Set<T>().Remove(item);
            contexto.SaveChanges();

        }
        public virtual void Editar(T item)
        {
            contexto.Entry(item).State = EntityState.Modified;
            contexto.SaveChanges();
        }
        public virtual T ObtemPorId(object id)
        {
            return contexto.Set<T>().Find(id);
        }
        public virtual IQueryable<T> Tudo()
        {
            return contexto.Set<T>();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
