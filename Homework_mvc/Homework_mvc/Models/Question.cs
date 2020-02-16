using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_mvc.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public Question()
        {
            Profiles = new List<Profile>();
            Users = new List<User>();
        }        
    }
}