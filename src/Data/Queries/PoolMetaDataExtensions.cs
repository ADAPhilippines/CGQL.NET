using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class PoolMetaDataExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.PoolMetaData GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.PoolMetaData> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolMetaData> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.PoolMetaData> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.PoolMetaData> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolMetaData> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.PoolMetaData>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolMetaData> ByRegisteredTxId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolMetaData> queryable, long registeredTxId)
        {
            return queryable.Where(q => q.RegisteredTxId == registeredTxId);
        }

        #endregion

    }
}
