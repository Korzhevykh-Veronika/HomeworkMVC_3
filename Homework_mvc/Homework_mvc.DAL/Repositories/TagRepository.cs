using Homework_mvc.DAL.Repositories.Interfaces;
using Homework_mvc.Entities;
using Homework_mvc.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_mvc.DAL.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogContext db;

        public TagRepository(BlogContext context)
        {
            this.db = context;
        }

        public void Create(Tag item)
        {
            db.Tags.Add(item);

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var tagToDelete = db.Tags.Find(id);

            if (tagToDelete != null)
            {
                db.Tags.Remove(tagToDelete);
            }
        }

        public Tag Get(int id)
        {
            return db.Tags.Find(id);
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags.ToList();
        }

        public void Update(Tag item)
        {
            
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();

        }
    }

}
