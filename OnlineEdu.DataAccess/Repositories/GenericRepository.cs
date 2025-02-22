using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Repositories
{
    // (OnlineEduContext _context)  bu yapı primary contructor diye geciyor .net8 ile gelmiş
    public class GenericRepository<T>(OnlineEduContext _context) : IRepository<T> where T : class
    {
        //private readonly OnlineEduContext _context;    -> bu yöntem eskiden oluşturuluyordu böyle artık yukarıda ki gibi instance oluşturabiliyoruz

        public DbSet<T> Table { get => _context.Set<T>(); } // table aşagıda her seferinde set etmemek için böyle bir yapıyla otomatik yapıyoruz
        public int Count()
        {
            return Table.Count();
        }

        public void Create(T entity)
        {
            // Burada create metodu return beklemediği için entity i add yapıp değişiklikleri kaydetmesini sağlıuyoruz
            Table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Table.Find(id);
            Table.Remove(entity);
            _context.SaveChanges();

        }

        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).FirstOrDefault();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public List<T> GetList()
        {
            return Table.ToList();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            _context.SaveChanges();
        }
    }
}
