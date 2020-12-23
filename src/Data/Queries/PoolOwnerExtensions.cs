using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class PoolOwnerExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.PoolOwner GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.PoolOwner> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolOwner> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.PoolOwner> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.PoolOwner> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolOwner> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.PoolOwner>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolOwner> ByPoolHashId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolOwner> queryable, long poolHashId)
        {
            return queryable.Where(q => q.PoolHashId == poolHashId);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolOwner> ByRegisteredTxId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolOwner> queryable, long registeredTxId)
        {
            return queryable.Where(q => q.RegisteredTxId == registeredTxId);
        }

        #endregion

    }
}
