using Homework_mvc.Entities;
using System.Collections.Generic;

namespace Homework_mvc.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual List<Article> Articles { get; set; }

    }
}
