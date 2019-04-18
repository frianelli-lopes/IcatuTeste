using IcatuTeste.Domain.Interfaces.Repositories;
using IcatuTeste.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace IcatuTeste.Infra.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected IcatuTesteContext Db;

        public BaseRepository(IcatuTesteContext context)
        {
            Db = context;
        }

        public void Alterar(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Excluir(int id)
        {
            var entity = RecuperarPorId(id);
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();
        }

        public void Incluir(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public List<T> Listar()
        {
            return Db.Set<T>().ToList();
        }

        public T RecuperarPorId(int id)
        {
            return Db.Set<T>().Find(id);
        }
    }
}
