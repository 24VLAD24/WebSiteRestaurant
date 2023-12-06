using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebSiteRestaurant.Models.Data;

namespace WebSiteRestaurant.ViewModels.Products
{
    public class CreateProductsViewModel
    {
        [Required(ErrorMessage = "Введите наименование товара")]
        [Display(Name = "Форма обучения")]

        public string ProductName { get; set; }

        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Категория")]
        public byte IdCategory { get; set; }
    }
}
