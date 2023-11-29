using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.ViewModels.Categories
{
    public class EditCategoriesViewModel
    {
        public byte Id { get; set; }

        [Required(ErrorMessage = "Введите наименование категории")]
        [Display(Name = "Форма обучения")]

        public string CategoryName { get; set; }
    }

}
