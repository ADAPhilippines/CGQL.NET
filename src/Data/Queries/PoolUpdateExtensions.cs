using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class PoolUpdateExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> ByHashId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> queryable, long hashId)
        {
            return queryable.Where(q => q.HashId == hashId);
        }

        public static CGQL.NET.Server.Data.Entities.PoolUpdate? GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolUpdate> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.PoolUpdate> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolUpdate> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.PoolUpdate>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> ByMetaId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> queryable, long? metaId)
        {
            return queryable.Where(q => (q.MetaId == metaId || (metaId == null && q.MetaId == null)));
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> ByRegisteredTxId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolUpdate> queryable, long registeredTxId)
        {
            return queryable.Where(q => q.RegisteredTxId == registeredTxId);
        }

        #endregion

    }
}
