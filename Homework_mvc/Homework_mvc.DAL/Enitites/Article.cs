using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework_mvc.Entities
{
    public class Article
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Название статьи")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Display(Name = "Картинка")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Images { get; internal set; }

        [Display(Name = "Автор статьи")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.Text)]
        public string Author { get; set; }

        [Display(Name = "Текст статьи")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name = "Дата публикации")]
        public DateTime Date { get; set; }
        public virtual List<Tag> Tags { get; set; }
        
    }
}