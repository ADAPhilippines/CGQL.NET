using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class PoolHashExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.PoolHash GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.PoolHash> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolHash> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.PoolHash> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.PoolHash> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolHash> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.PoolHash>(task);
        }

        #endregion

    }
}
