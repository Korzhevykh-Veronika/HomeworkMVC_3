using Homework_mvc.DAL;
using Homework_mvc.Entities;
using Homework_mvc.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_mvc.Services
{
    public class MainService
    {
        UnitOfWork unitOfWork;
        public MainService()
        {
            unitOfWork = new UnitOfWork();
        }
        public IEnumerable<Entities.Article> GetArticles()
        {            
           var articles= unitOfWork.Articles.GetAll();
            foreach(var a in articles)
            {
                a.Text = a.Text.Substring(0, 200)+"...";
            }
            return articles;

        }
        public Article GetArticle(int id)
        {
            return unitOfWork.Articles.Get(id);
        }

        public IEnumerable<Entities.Review> GetReviews()
        {
            return unitOfWork.Reviews.GetAll();
        }
        public IEnumerable<Entities.Tag> GetTags()
        {
            return unitOfWork.Tags.GetAll();
        }

        public IEnumerable<Question> GetQuestions()
        {
            return unitOfWork.Questions.GetAll();
        }

        internal void CreateReview(Entities.Review review)
        {
            unitOfWork.Reviews.Create(review);
        }
        public void UpdateArticle(Article article)
        {
            unitOfWork.Articles.Update(article);
        }
        public void CreateUser(User user)
        {
            for (int i = 0; i < user.Profiles.Count; i++)
            {
                user.Profiles[i].QuestionId = user.Questions[i].Id;
            }

            user.Profiles = user.Profiles.Where(profile => profile.Text != null).ToList();
            user.Questions.Clear();

            unitOfWork.Users.Create(user);
        }
    }
}