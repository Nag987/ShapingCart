using OnlineShapingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShapingStore.Domain.Abstract
{
   public interface IProductRepositary
    {
       IEnumerable<Product> Product { get; }
    }
}
