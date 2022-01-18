using backendProiect.Entities;
using backendProiect.Managers;
using backendProiect.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewsManager manager;
        public ReviewController(IReviewsManager reviewsManager)
        {
            this.manager = reviewsManager;
        }
        [HttpGet]

        public async Task<IActionResult> GetReviews()
        {
            var reviews = manager.GetReviews();
            return Ok(reviews);
        }

        [HttpGet("select-review-id")]
        public async Task<IActionResult> GetReviewIds()
        {
            var idList = manager.GetReviewIdsList();
            return Ok(idList);
        }
        [HttpPost]
        [Authorize(Policy = "BasicUser")]
        public async Task<IActionResult> CreateReview([FromBody] ReviewModel reviewModel)
        {
            manager.CreateReview(reviewModel);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReview([FromBody] ReviewModel reviewModel)
        {
            manager.UpdateReview(reviewModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteReview([FromRoute] int id)
        {
            manager.DeleteReview(id);
            return Ok();
        }
    }
}
