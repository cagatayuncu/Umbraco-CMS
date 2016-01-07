using System.Linq;
using Umbraco.Core.Collections;
using Umbraco.Core.Models.EntityBase;

namespace Umbraco.Core.Cache
{
    /// <summary>
    /// A caching policy that ignores all caches for GetAll - it will only cache calls for individual items
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
    internal class OnlySingleItemsRepositoryCachePolicy<TEntity, TId> : DefaultRepositoryCachePolicy<TEntity, TId>
        where TEntity : class, IAggregateRoot
    {
        public OnlySingleItemsRepositoryCachePolicy(IRuntimeCacheProvider cache, RepositoryCachePolicyOptions options) : base(cache, options)
        {
        }
        
        protected override void SetCacheAction(TId[] ids, TEntity[] entityCollection)
        {            
            //do nothing
        }
    }
}