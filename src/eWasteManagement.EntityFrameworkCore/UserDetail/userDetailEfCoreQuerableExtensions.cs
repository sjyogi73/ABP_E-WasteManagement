using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace eWasteManagement.UserDetail
{
    public static class userDetailEfCoreQueryableExtensions
    {
        public static IQueryable<userDetail> IncludeDetails(this IQueryable<userDetail> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}