using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductRepo : Repo, IRepo<Product, int, bool>
    {
        public bool Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Products.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Product> Read()
        {
            return db.Products.ToList();
        }

        public Product Read(int id)
        {
            return db.Products.Find(id);
        }

        public bool Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
