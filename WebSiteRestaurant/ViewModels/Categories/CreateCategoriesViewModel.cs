using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.ViewModels.Categories
{
    public class CreateCategoriesViewModel
    {

        [Required(ErrorMessage = "Введите наименование категории")]
        [Display(Name = "Форма обучения")]

        public string CategoryName { get; set; }
    }

}
