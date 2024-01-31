using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class CartSummaryViewModel
    {
        public Cart _cartSessionService { get;internal set; }
        public Cart Cart { get; internal set; }
    }
}