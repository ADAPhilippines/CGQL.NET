using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using CGQL.NET.Server.Data.Entities;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server
{
    public class Query
    {
        public Task<Block> GetBlockAsync(int id, BlockByNoDataLoader dataLoader, CancellationToken cancellationToken) => dataLoader.LoadAsync(id, cancellationToken);
        public Task<Address> GetAddressAsync(string hash, AddressDataLoader dataLoader, CancellationToken cancellationToken) => dataLoader.LoadAsync(hash, cancellationToken);
    }
}