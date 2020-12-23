using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class WithdrawalExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.Withdrawal> ByAddrId(this IQueryable<CGQL.NET.Server.Data.Entities.Withdrawal> queryable, long addrId)
        {
            return queryable.Where(q => q.AddrId == addrId);
        }

        public static CGQL.NET.Server.Data.Entities.Withdrawal GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.Withdrawal> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Withdrawal> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.Withdrawal> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.Withdrawal> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Withdrawal> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.Withdrawal>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Withdrawal> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.Withdrawal> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
