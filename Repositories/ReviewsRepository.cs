using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public class ReviewsRepository : IReviewsRepository
    {
        private backendProiectContext db;
        public ReviewsRepository(backendProiectContext db)
        {
            this.db = db;
        }

        public void CreateReview(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public void DeleteReview(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }

        public IQueryable<Review> GetReviewsIQueryable()
        {
            var reviews = db.Reviews;
            return reviews;
        }

        public void UpdateReview(Review review)
        {
            db.Reviews.Update(review);
            db.SaveChanges();
        }
    }
}
