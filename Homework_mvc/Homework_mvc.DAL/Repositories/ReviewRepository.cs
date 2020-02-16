using Homework_mvc.DAL.Repositories.Interfaces;
using Homework_mvc.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Homework_mvc.Infrastructure.Data
{
    public class ReviewRepository : IRepository<Review>
    {
        private BlogContext db;

        public ReviewRepository(BlogContext context)
        {
            this.db = context;
        }

        public void Create(Review item)
        {
            item.Date = DateTime.Today;
            db.Entry(item).State = EntityState.Added;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Review Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public void Update(Review item)
        {

            throw new System.NotImplementedException();
        }
    }

}

