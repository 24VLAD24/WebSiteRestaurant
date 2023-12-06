using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.Models.Data
{
    public class OrderList
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Заказ")]
        public int IdOrder { get; set; }

        [Display(Name = "Заказ")]
        [ForeignKey("IdOrder")]
        public Order Order { get; set; }

        [Display(Name = "Количество товара")]
        public int CountProduct { get; set; }
    }
}
