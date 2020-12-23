using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class PoolRetireProfile
        : AutoMapper.Profile
    {
        public PoolRetireProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.PoolRetire, CGQL.NET.Server.Domain.Models.PoolRetireReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolRetireCreateModel, CGQL.NET.Server.Data.Entities.PoolRetire>();

            CreateMap<CGQL.NET.Server.Data.Entities.PoolRetire, CGQL.NET.Server.Domain.Models.PoolRetireUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolRetireUpdateModel, CGQL.NET.Server.Data.Entities.PoolRetire>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolRetireReadModel, CGQL.NET.Server.Domain.Models.PoolRetireUpdateModel>();

        }

    }
}
