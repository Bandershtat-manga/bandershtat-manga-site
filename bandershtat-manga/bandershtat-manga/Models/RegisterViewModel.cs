using System.ComponentModel.DataAnnotations;

namespace bandershtat_manga.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Поле 'Нік' є обов'язковим.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле 'Email' є обов'язковим.")]
        [EmailAddress(ErrorMessage = "Введіть правильний Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле 'Пароль' є обов'язковим.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Паролі не співпадають.")]
        public string ConfirmPassword { get; set; }
    }


}
