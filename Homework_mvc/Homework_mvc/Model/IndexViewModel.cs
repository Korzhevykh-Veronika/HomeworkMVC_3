using Homework_mvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_mvc.Model
{
    public class IndexViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public PageInfo PageInfo { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<int> CheckedTags { get; set; }
        public string SearchPattern { get; set; }

    }
}