using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class PoolRelayExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.PoolRelay GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.PoolRelay> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolRelay> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.PoolRelay> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.PoolRelay> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolRelay> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.PoolRelay>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolRelay> ByUpdateId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolRelay> queryable, long updateId)
        {
            return queryable.Where(q => q.UpdateId == updateId);
        }

        #endregion

    }
}
