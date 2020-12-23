using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class TxInExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.TxIn GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.TxIn> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.TxIn> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.TxIn> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.TxIn> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.TxIn> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.TxIn>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.TxIn> ByTxInId(this IQueryable<CGQL.NET.Server.Data.Entities.TxIn> queryable, long txInId)
        {
            return queryable.Where(q => q.TxInId == txInId);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.TxIn> ByTxOutId(this IQueryable<CGQL.NET.Server.Data.Entities.TxIn> queryable, long txOutId)
        {
            return queryable.Where(q => q.TxOutId == txOutId);
        }

        #endregion

    }
}
