using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tagId, int page, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        /// <summary>
        /// Return list all paging of Post by Tag
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="page">index of current Page</param>
        /// <param name="pageSize">the number of record display in a Page</param>
        /// <param name="totalRow">total Product</param>
        /// <returns></returns>
        public IEnumerable<Post> GetAllByTag(string tagId, int page, int pageSize, out int totalRow)
        {
            var query = from post in DbContext.Posts
                        join postTag in DbContext.PostTags on post.Id equals postTag.PostId
                        where postTag.TagId == tagId && post.Status
                        orderby post.CreatedDate descending
                        select post;

            totalRow = query.Count();

            return query.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}