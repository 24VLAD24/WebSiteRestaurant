using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.Models.Data
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите наименование товара")]
        [Display(Name = "Наименование товара")]

        public string ProductName { get; set; }

        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Категория")]
        public byte IdCategory { get; set; }

        // Навигационные свойства
        [Display(Name = "Категория")]
        [ForeignKey("IdCategory")]
        public Category Category { get; set; }

        // Навигационные свойства
        public ICollection<PriceProduct> PriceProducts { get; set; }

    }

}
