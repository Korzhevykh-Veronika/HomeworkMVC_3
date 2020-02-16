using Homework_mvc.DAL.Repositories.Interfaces;
using Homework_mvc.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Homework_mvc.Infrastructure.Data
{
    public class QuestionRepository : IRepository<Question>
    {
        private BlogContext db;

        public QuestionRepository(BlogContext context)
        {
            this.db = context;
        }

        public void Create(Question item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Question Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Question> GetAll()
        {
            return db.Questions.ToList();
        }

        public void Update(Question item)
        {
            throw new System.NotImplementedException();
        }
    }

}

