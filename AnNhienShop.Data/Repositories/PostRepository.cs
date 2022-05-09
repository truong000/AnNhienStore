using AnNhienShop.Data.Infrastucture;
using AnNhienShop.Model.Models;

namespace AnNhienShop.Data.Repositories
{
    public interface IPostRepository
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}