using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {

        Context co = new Context();
        DbSet<Category> _object;

        public void Delete(Category c)
        {
            _object.Remove(c);
            co.SaveChanges();
        }

        public void Insert(Category c)
        {
            _object.Add(c);
            co.SaveChanges();

        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Update(Category c)
        {
            co.SaveChanges();
        }
    }
}
