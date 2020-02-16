using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_mvc.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Images { get; set; }
        public DateTime Date { get; set; }

        public string Title { get; set; }

    }
}