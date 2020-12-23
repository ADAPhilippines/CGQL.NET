using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class BlockExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.Block> ByBlockNo(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, int? blockNo)
        {
            return queryable.Where(q => (q.BlockNo == blockNo || (blockNo == null && q.BlockNo == null)));
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Block> ByEpochNo(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, int? epochNo)
        {
            return queryable.Where(q => (q.EpochNo == epochNo || (epochNo == null && q.EpochNo == null)));
        }

        public static CGQL.NET.Server.Data.Entities.Block GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Block> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.Block> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Block> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.Block>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Block> ByPreviousId(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, long? previousId)
        {
            return queryable.Where(q => (q.PreviousId == previousId || (previousId == null && q.PreviousId == null)));
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Block> BySlotLeaderId(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, long slotLeaderId)
        {
            return queryable.Where(q => q.SlotLeaderId == slotLeaderId);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Block> BySlotNo(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, int? slotNo)
        {
            return queryable.Where(q => (q.SlotNo == slotNo || (slotNo == null && q.SlotNo == null)));
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.Block> ByTime(this IQueryable<CGQL.NET.Server.Data.Entities.Block> queryable, DateTime time)
        {
            return queryable.Where(q => q.Time == time);
        }

        #endregion

    }
}
