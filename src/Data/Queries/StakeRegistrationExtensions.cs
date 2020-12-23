using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class StakeRegistrationExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.StakeRegistration> ByAddrId(this IQueryable<CGQL.NET.Server.Data.Entities.StakeRegistration> queryable, long addrId)
        {
            return queryable.Where(q => q.AddrId == addrId);
        }

        public static CGQL.NET.Server.Data.Entities.StakeRegistration GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.StakeRegistration> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.StakeRegistration> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.StakeRegistration> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.StakeRegistration> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.StakeRegistration> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.StakeRegistration>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.StakeRegistration> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.StakeRegistration> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
