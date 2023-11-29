using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebSiteRestaurant.Models.Data
{
    public class User: IdentityUser
    {
        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Дата Рождения")]
        public string DateBirth { get; set; }

        [Display(Name = "Дата регистрации")]
        public string DateRegistration { get; set; }
    }
}
