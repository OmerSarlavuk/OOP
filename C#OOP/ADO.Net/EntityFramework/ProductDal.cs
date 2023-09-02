using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ProductDal
    {
        
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                var obje = context.Products.ToList();
                return obje;
            }
        }
        public List<Product> GetName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var obje = context.Products.Where(p => p.Name.Contains(key)).ToList();
                return obje;
            }
        }

        public List<Product> GetStockAmount(int stock)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var obje = context.Products.Where(s => s.StockAmount >= 20).ToList();
                return obje;
            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var obje = context.Products.Where(u => u.UnitPrice >= min && u.UnitPrice <= max).ToList();
                return obje;
            }
        }

        public void Add(Product product)
        {
           using(ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();



            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
