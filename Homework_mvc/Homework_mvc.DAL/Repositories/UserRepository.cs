using Homework_mvc.DAL.Repositories.Interfaces;
using Homework_mvc.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Homework_mvc.Infrastructure.Data
{
    public class UserRepository : IRepository<User>
    {
        private BlogContext db;

        public UserRepository(BlogContext context)
        {
            this.db = context;
        }

        public void Create(User item)
        {
            db.Users.Add(item);

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }

}

