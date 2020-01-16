using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesla.Data;
using Tesla.Data.Entities;

namespace Tesla.Business.Services
{
    public interface IReviewService
    {
        Task<Review> Add(string content, bool sentiment);

    }
    public class ReviewService : IReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Review> Add(string content, bool sentiment)
        {
            var review = new Review
            {
                SentimentText = content,
                Sentiment = sentiment
            };

            var result = await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
