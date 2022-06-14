using System.ComponentModel.DataAnnotations;

namespace AwesomeNetworkM35.ViewModel
{
    public class LoginViewModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmailLogin { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль", Prompt = "Введите пароль")]
        public string PasswordLogin { get; set; }

        [Display(Name = "Запомнить учетные данные?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

    }
}
