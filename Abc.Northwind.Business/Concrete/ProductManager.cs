﻿using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
          _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId=productId});
        }

        public List<Product> GetProductsByCategory()
        {
            return _productDal.GetList();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetList(p=> p.CategoryId == categoryId || categoryId==0);
        }

        public Product GetProductsById(int productId)
        {
            return _productDal.Get(p=>p.ProductId==productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
