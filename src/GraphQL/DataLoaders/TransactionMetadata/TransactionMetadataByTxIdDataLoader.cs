using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CGQL.NET.Models;

namespace CGQL.NET.Server.GraphQL.DataLoaders
{
    public class TransactionMetadataByIdDataLoader : BatchDataLoader<long, TransactionMetadata>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public TransactionMetadataByIdDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<long, TransactionMetadata>> LoadBatchAsync(
            IReadOnlyList<long> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            var txMetas = await (from txMeta in dbContext.TxMetadata
                where keys.Contains(txMeta.Id)
                select txMeta).ToListAsync(cancellationToken);

            var result = new Dictionary<long, TransactionMetadata>();

            foreach(var meta in txMetas)
            {
                result.Add(meta.Id, new TransactionMetadata(meta.Key, 
                    meta.Json, 
                    new Transaction(meta.TxId.ToString(),
                        default!, default!, default!, default!,
                        default!, default!, default!, default!, 
                        default!, default!)));
            }

            return result;
        }
    }
}
