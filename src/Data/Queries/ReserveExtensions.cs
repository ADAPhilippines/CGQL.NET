using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class ReserveExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.Reserve> ByAddrId(this IQueryable<CGQL.NET.Server.Data.Entities.Reserve> queryable, long addrId)
        {
            return queryable.Where(q => q.AddrId == addrId);
        }

        public static CGQL.NET.Server.Data.Entities.Reserve GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.Reserve> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Reserve> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.Reserve> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.Reserve> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Reserve> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.Reserve>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Reserve> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.Reserve> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
