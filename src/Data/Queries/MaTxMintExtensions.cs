using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class MaTxMintExtensions
    {
        #region Generated Extensions
        public static CGQL.NET.Server.Data.Entities.MaTxMint GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.MaTxMint> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.MaTxMint> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.MaTxMint> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.MaTxMint> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.MaTxMint> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.MaTxMint>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.MaTxMint> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.MaTxMint> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
