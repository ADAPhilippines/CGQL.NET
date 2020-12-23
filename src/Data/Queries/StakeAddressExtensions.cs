using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class StakeAddressExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.StakeAddress GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.StakeAddress> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.StakeAddress> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.StakeAddress> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.StakeAddress> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.StakeAddress> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.StakeAddress>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.StakeAddress> ByRegisteredTxId(this IQueryable<CGQL.NET.Server.Data.Entities.StakeAddress> queryable, long registeredTxId)
        {
            return queryable.Where(q => q.RegisteredTxId == registeredTxId);
        }

        #endregion

    }
}
