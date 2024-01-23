using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }

        public int CurrentCategory { get; internal set; }
    }
}
