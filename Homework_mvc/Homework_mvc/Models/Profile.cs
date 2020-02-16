using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_mvc.Models
{
    public class Profile
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int? QuestionId { get; set; }

        public int? UserId { get; set; }

        public virtual Question Question { get; set; }
        public virtual User User { get; set; }

    }
}