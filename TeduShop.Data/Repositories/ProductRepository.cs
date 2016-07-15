using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetListProductByTag(string tagId, int page, int pageSize, out int totalRow);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        /// <summary>
        /// Return list all paging of Product by Tag
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="page">index of current Page</param>
        /// <param name="pageSize">the number of record display in a Page</param>
        /// <param name="totalRow">total Product</param>
        /// <returns></returns>
        public IEnumerable<Product> GetListProductByTag(string tagId, int page, int pageSize, out int totalRow)
        {
            var query = from product in DbContext.Products
                        join productTag in DbContext.ProductTags on product.Id equals productTag.ProductId
                        where productTag.TagId == tagId
                        select product;

            totalRow = query.Count();

            return query.OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}