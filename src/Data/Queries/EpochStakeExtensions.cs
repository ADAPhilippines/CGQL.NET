using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class EpochStakeExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> ByAddrId(this IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> queryable, long addrId)
        {
            return queryable.Where(q => q.AddrId == addrId);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> ByBlockId(this IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> queryable, long blockId)
        {
            return queryable.Where(q => q.BlockId == blockId);
        }

        public static CGQL.NET.Server.Data.Entities.EpochStake GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.EpochStake> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.EpochStake> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.EpochStake> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.EpochStake>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> ByPoolId(this IQueryable<CGQL.NET.Server.Data.Entities.EpochStake> queryable, long poolId)
        {
            return queryable.Where(q => q.PoolId == poolId);
        }

        #endregion

    }
}
