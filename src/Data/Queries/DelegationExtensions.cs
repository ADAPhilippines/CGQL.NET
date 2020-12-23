using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class DelegationExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.Delegation> ByAddrId(this IQueryable<CGQL.NET.Server.Data.Entities.Delegation> queryable, long addrId)
        {
            return queryable.Where(q => q.AddrId == addrId);
        }

        public static CGQL.NET.Server.Data.Entities.Delegation GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.Delegation> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Delegation> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.Delegation> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.Delegation> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Delegation> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.Delegation>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Delegation> ByPoolHashId(this IQueryable<CGQL.NET.Server.Data.Entities.Delegation> queryable, long poolHashId)
        {
            return queryable.Where(q => q.PoolHashId == poolHashId);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Delegation> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.Delegation> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
