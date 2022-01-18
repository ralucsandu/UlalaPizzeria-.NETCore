using backendProiect.Entities;
using backendProiect.Models;
using backendProiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace backendProiect.Managers
{
    public class ReviewsManager : IReviewsManager
    {
        private readonly IReviewsRepository reviewsRepository;
        public ReviewsManager(IReviewsRepository reviewsRepository)
        {
            this.reviewsRepository = reviewsRepository;
        }
        public List<Review> GetReviews()
        {
            return reviewsRepository.GetReviewsIQueryable().ToList();
        }
        public List<int> GetReviewIdsList()
        {
            var reviews = reviewsRepository.GetReviewsIQueryable();
            var idList = reviews.Select(x => x.ReviewId)
                .ToList();

            return idList;
        }
        public Review GetReviewById(int id)
        {
            var review = reviewsRepository.GetReviewsIQueryable()
                .FirstOrDefault(x => x.ReviewId == id);
            return review;
        }
        public void CreateReview(ReviewModel reviewModel)
        {
            var newReview = new Review
            {
                ReviewId = reviewModel.ReviewId,
                Content = reviewModel.Content,
                FoodId = reviewModel.FoodId
            };

            reviewsRepository.CreateReview(newReview);
        }

        public void UpdateReview(ReviewModel reviewModel)
        {
            var review = GetReviewById(reviewModel.ReviewId);
            review.Content = reviewModel.Content;
            reviewsRepository.UpdateReview(review);
        }

        public void DeleteReview(int ReviewId)
        {
            var review = GetReviewById(ReviewId);
            reviewsRepository.DeleteReview(review);
        }
    }
}
