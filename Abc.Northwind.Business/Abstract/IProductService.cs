using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProductsByCategory();
        List<Product> GetProductsByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetProductsById(int productId);
    }
}
