using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.Models.Data
{
    public class PriceProduct
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public int Id { get; set; }

        [Display(Name = "Стоимость")]
        public decimal Price { get; set; }

        [Display(Name = "Дата добавления стоимости")]
        public DateTime DatePrice { get; set; }

        [Required]
        [Display(Name = "Товар")]
        public int IdProduct { get; set; }

        [Display(Name = "Товар")]
        [ForeignKey("IdProduct")]
        public Product Product { get; set; }
    }
}
