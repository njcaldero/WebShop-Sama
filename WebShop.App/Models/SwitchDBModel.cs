using System.ComponentModel.DataAnnotations;

namespace WebShop.App.Models
{
    public class SwitchDBModel
    {
        [Display(Name = "Switch DB")]
        public bool InMemoryDB { get; set; }
    }
}
