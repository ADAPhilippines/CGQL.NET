using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class MaTxOutExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.MaTxOut GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.MaTxOut> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.MaTxOut> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.MaTxOut> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.MaTxOut> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.MaTxOut> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.MaTxOut>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.MaTxOut> ByTxOutId(this IQueryable<CGQL.NET.Server.Data.Entities.MaTxOut> queryable, long txOutId)
        {
            return queryable.Where(q => q.TxOutId == txOutId);
        }

        #endregion

    }
}
