using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public interface IReviewsRepository
    {
        IQueryable<Review> GetReviewsIQueryable();
        void CreateReview(Review review);
        void UpdateReview(Review review);
        void DeleteReview(Review review);
    }
}
