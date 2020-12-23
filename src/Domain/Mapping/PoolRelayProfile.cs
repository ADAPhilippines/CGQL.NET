using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class PoolRelayProfile
        : AutoMapper.Profile
    {
        public PoolRelayProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.PoolRelay, CGQL.NET.Server.Domain.Models.PoolRelayReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolRelayCreateModel, CGQL.NET.Server.Data.Entities.PoolRelay>();

            CreateMap<CGQL.NET.Server.Data.Entities.PoolRelay, CGQL.NET.Server.Domain.Models.PoolRelayUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolRelayUpdateModel, CGQL.NET.Server.Data.Entities.PoolRelay>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolRelayReadModel, CGQL.NET.Server.Domain.Models.PoolRelayUpdateModel>();

        }

    }
}
