using Abc.Northwind.Business.Abstract;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;

namespace Abc.Northwind.MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])

            };
            return View(model);
        }
    }
}