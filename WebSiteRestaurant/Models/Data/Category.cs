using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSiteRestaurant.Models.Data
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public byte Id { get; set; }

        [Required(ErrorMessage = "Введите наименование категории")]
        [Display(Name = "Наименование категории")]

        public string CategoryName { get; set; }
    }
}
