using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.Models.Data
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите пожелание к заказу")]
        [Display(Name = "Пожелание к заказу")]
        public string? WishOrder { get; set; }

        [Display(Name = "Дата заказа")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Статус оплаты")]
        public bool? PaymentState { get; set; }

        [Required]
        [Display(Name = "Пользователь")]
        public string IdUser { get; set; }

        // Навигационные свойства
        [Display(Name = "Пользователь")]
        [ForeignKey("IdUser")]
        public User User { get; set; }

        public ICollection<OrderList> OrdersList { get; set; }
    }
}
