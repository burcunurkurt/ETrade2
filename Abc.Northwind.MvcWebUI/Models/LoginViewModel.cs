using System.ComponentModel.DataAnnotations;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool RememberMe { get; set; }
        
    }
}
