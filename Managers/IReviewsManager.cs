using backendProiect.Entities;
using backendProiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public interface IReviewsManager
    {
        List<Review> GetReviews();
        List<int> GetReviewIdsList();
        Review GetReviewById(int id);
        void CreateReview(ReviewModel reviewModel);
        void UpdateReview(ReviewModel reviewModel);
        void DeleteReview(int ReviewId);
    }
}
