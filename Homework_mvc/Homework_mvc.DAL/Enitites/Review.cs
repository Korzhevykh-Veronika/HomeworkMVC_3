using System;
using System.ComponentModel.DataAnnotations;

namespace Homework_mvc.Entities
{
    public class Review
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Text { get; set; }

        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё''-'\s]+$", ErrorMessage = "Некорректное имя")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Имя автора отзыва не может содержать меньше 2 символов и более 20 символов")]
        public string Author { get; set; }
    }
}