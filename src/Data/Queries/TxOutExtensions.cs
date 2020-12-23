using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Queries
{
    public static partial class TxOutExtensions
    {
        #region Generated Extensions
        public static IQueryable<CGQL.NET.Server.Data.Entities.TxOut> ByAddress(this IQueryable<CGQL.NET.Server.Data.Entities.TxOut> queryable, string address)
        {
            return queryable.Where(q => q.Address == address);
        }

        public static CGQL.NET.Server.Data.Entities.TxOut? GetByKey(this IQueryable<CGQL.NET.Server.Data.Entities.TxOut> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.TxOut> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<CGQL.NET.Server.Data.Entities.TxOut> GetByKeyAsync(this IQueryable<CGQL.NET.Server.Data.Entities.TxOut> queryable, long id)
        {
            if (queryable is DbSet<CGQL.NET.Server.Data.Entities.TxOut> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CGQL.NET.Server.Data.Entities.TxOut>(task);
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.TxOut> ByPaymentCred(this IQueryable<CGQL.NET.Server.Data.Entities.TxOut> queryable, Byte[] paymentCred)
        {
            return queryable.Where(q => (q.PaymentCred == paymentCred || (paymentCred == null && q.PaymentCred == null)));
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.TxOut> ByStakeAddressId(this IQueryable<CGQL.NET.Server.Data.Entities.TxOut> queryable, long? stakeAddressId)
        {
            return queryable.Where(q => (q.StakeAddressId == stakeAddressId || (stakeAddressId == null && q.StakeAddressId == null)));
        }

        public static IQueryable<CGQL.NET.Server.Data.Entities.TxOut> ByTxId(this IQueryable<CGQL.NET.Server.Data.Entities.TxOut> queryable, long txId)
        {
            return queryable.Where(q => q.TxId == txId);
        }

        #endregion

    }
}
