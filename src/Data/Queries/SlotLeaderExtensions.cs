using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class SlotLeaderExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.SlotLeader GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.SlotLeader> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.SlotLeader> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.SlotLeader> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.SlotLeader> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.SlotLeader> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.SlotLeader>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.SlotLeader> ByPoolHashId(this IQueryable<CGQL.NET.Server.Data.Entities.SlotLeader> queryable, long? poolHashId)
        {
            return queryable.Where(q => (q.PoolHashId == poolHashId || (poolHashId == null && q.PoolHashId == null)));
        }

        #endregion

    }
}
