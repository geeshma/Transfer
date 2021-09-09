using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Demo3.Entities;

namespace Demo3.Repositories
{
    interface IProduct_Repository
    {
        void AddProduct(Product product);
        Product GetProduct(int pid);
        List<Product> GetProducts();
        void DeleteProduct(int pid);
        void UpdateProduct(Product product);
    }
}
