using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.Models.Data
{
    public class User: IdentityUser
    {
        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите фамилию")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите дату рождения")]
        [Display(Name = "Дата рождения")]
        public DateTime DateBirth { get; set; }

        [Display(Name = "Дата регистрации")]
        public DateTime DateRegistration { get; set; }
    }
}
