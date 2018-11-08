using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Core.Domain;

namespace ShoppingCart.Core.Facade
{
    public interface IProductsRepository
    {
        //CRUD
        IEnumerable<Product> FindAll();

    }
}
