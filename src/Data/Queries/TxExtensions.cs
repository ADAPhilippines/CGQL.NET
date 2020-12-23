using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class TxExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.Tx> ByBlockId(this IQueryable<CGQL.NET.Server.Data.Entities.Tx> queryable, long blockId)
        {
            return queryable.Where(q => q.BlockId == blockId);
        }

        public static CGQL.NET.Server.Data.Entities.Tx GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.Tx> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Tx> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.Tx> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.Tx> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.Tx> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.Tx>(task);
        }

        #endregion

    }
}
