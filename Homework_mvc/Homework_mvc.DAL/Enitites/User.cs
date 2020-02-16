using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework_mvc.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё''-'\s]+$", ErrorMessage = "Некорректное имя")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Имя не может содержать меньше 2 символов и более 20 символов")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё''-'\s]+$", ErrorMessage = "Некорректная фамилия")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Фамилия не может содержать меньше 2 символов и более 20 символов")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Phone { get; set; }
        public string Gender { get; set; }

        public virtual List<Profile> Profiles { get; set; }
        public virtual List<Question> Questions { get; set; }

        public User()
        {
            Profiles = new List<Profile>();
            Questions = new List<Question>();
        }

    }
}