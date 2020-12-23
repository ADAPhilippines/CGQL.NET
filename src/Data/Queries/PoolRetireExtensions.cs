using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class PoolRetireExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolRetire> ByAnnouncedTxId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolRetire> queryable, long announcedTxId)
        {
            return queryable.Where(q => q.AnnouncedTxId == announcedTxId);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.PoolRetire> ByHashId(this IQueryable<CGQL.NET.Server.Data.Entities.PoolRetire> queryable, long hashId)
        {
            return queryable.Where(q => q.HashId == hashId);
        }

        public static CGQL.NET.Server.Data.Entities.PoolRetire GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.PoolRetire> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolRetire> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.PoolRetire> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.PoolRetire> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.PoolRetire> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.PoolRetire>(task);
        }

        #endregion

    }
}
