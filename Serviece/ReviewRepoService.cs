using Yummy.Data;
using Yummy.Models;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Serviece
{
    public class ReviewRepoService : IReview
    {
        public ApplicationDbContext _context;

        public ReviewRepoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Review> GetAllReview()
        {
            // Placeholder logic to get all reviews
            return _context.Reviews.ToList();
        }

        public Review GetReviewDetails(int id)
        {
            // Placeholder logic to get review details by ID
            return _context.Reviews.Find(id);
        }

        public void InsertReview(Review newReview)
        {
            // Placeholder logic to insert a new review
            _context.Reviews.Add(newReview);
            _context.SaveChanges();
        }

        public void UpdateReview(int id, Review updatedReview)
        {
            Review existingReview = _context.Reviews.Find(id);
            if (existingReview != null)
            {
                // Placeholder logic to update an existing review
                existingReview.Rating = updatedReview.Rating;
                existingReview.Comment = updatedReview.Comment;
                _context.SaveChanges();
            }
        }

        public void DeleteReview(int id)
        {
            Review reviewToDelete = _context.Reviews.Find(id);
            if (reviewToDelete != null)
            {
                // Placeholder logic to delete a review
                _context.Reviews.Remove(reviewToDelete);
                _context.SaveChanges();
            }
        }
    }
}
