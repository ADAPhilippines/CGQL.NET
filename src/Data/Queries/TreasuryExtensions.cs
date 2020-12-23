using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class TreasuryExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.Treasury> ByAddrId(this IQueryable<CGQL.NET.Server.Data.Entities.Treasury> queryable, long addrId)
        {
            return queryable.Where(q => q.AddrId == addrId);
        }

        public static CGQL.NET.Server.Data.Entities.Treasury? GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.Treasury> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Treasury> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.Treasury> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.Treasury> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Treasury> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.Treasury>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Treasury> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.Treasury> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
