using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class RewardExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.Reward> ByAddrId(this IQueryable<CGQL.NET.Server.Data.Entities.Reward> queryable, long addrId)
        {
            return queryable.Where(q => q.AddrId == addrId);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Reward> ByBlockId(this IQueryable<CGQL.NET.Server.Data.Entities.Reward> queryable, long blockId)
        {
            return queryable.Where(q => q.BlockId == blockId);
        }

        public static CGQL.NET.Server.Data.Entities.Reward? GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.Reward> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Reward> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.Reward> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.Reward> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Reward> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.Reward>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Reward> ByPoolId(this IQueryable<CGQL.NET.Server.Data.Entities.Reward> queryable, long poolId)
        {
            return queryable.Where(q => q.PoolId == poolId);
        }

        #endregion

    }
}
