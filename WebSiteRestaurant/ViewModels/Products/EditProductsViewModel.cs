using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.ViewModels.Products
{
    public class EditProductsViewModel
    {
        public int Id { get; set; }

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
