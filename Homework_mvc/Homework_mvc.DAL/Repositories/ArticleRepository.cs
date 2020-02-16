using Homework_mvc.DAL.Repositories.Interfaces;
using Homework_mvc.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Homework_mvc.Infrastructure.Data
{
    public class ArticleRepository : IRepository<Article>
    {
        private BlogContext db;

        public ArticleRepository(BlogContext context)
        {
            this.db = context;
        }

        public void Create(Article item)
        {
            db.Articles.Add(item);

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var articleToDelete = db.Articles.Find(id);

            if(articleToDelete != null)
            {
                db.Articles.Remove(articleToDelete);
            }
        }

        public Article Get(int id)
        {
            return db.Articles.Find(id);
        }

        public IEnumerable<Article> GetAll()
        {
            return db.Articles.ToList();
        }

        public void Update(Article item)
        {
            item.Date = DateTime.Today;
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();

        }
    }

}

