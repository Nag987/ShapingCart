using OnlineShapingStore.Domain.Abstract;
using OnlineShapingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShapingStore.Domain.Concrete
{
   public class EFProductRepositery:IProductRepositary 
    {
       private readonly EFDbContext context = new EFDbContext(); 
        public IEnumerable<Product> Product
        {
            get
            {
               return context.Products;
            }
       
        }
    }
}
