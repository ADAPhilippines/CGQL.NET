using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class TxMetadataExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.TxMetadata GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.TxMetadata> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.TxMetadata> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.TxMetadata> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.TxMetadata> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.TxMetadata> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.TxMetadata>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.TxMetadata> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.TxMetadata> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
