﻿using Abc.Northwind.Business.Abstract;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page=1, int category=0)
        {
            int pageSize = 10;
            var products = _productService.GetProductsByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                PageCount=(int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize=pageSize,              
                CurrentCategory=category,
                CurrentPage=page
            };
            return View(model);
        }
        
    }

}
