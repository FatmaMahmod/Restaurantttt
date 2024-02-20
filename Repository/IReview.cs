using Yummy.Models;
using YUMMY.Models;

namespace Yummy.Repository
{
    public interface IReview
    {
        public List<Review> GetAllReview();
        public Review GetReviewDetails(int id);
        public void InsertReview(Review Review);
        public void UpdateReview(int id, Review Review);
        public void DeleteReview(int id);
    }
}
