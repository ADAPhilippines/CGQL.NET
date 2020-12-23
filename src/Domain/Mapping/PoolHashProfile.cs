using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class PoolHashProfile
        : AutoMapper.Profile
    {
        public PoolHashProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.PoolHash, CGQL.NET.Server.Domain.Models.PoolHashReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolHashCreateModel, CGQL.NET.Server.Data.Entities.PoolHash>();

            CreateMap<CGQL.NET.Server.Data.Entities.PoolHash, CGQL.NET.Server.Domain.Models.PoolHashUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolHashUpdateModel, CGQL.NET.Server.Data.Entities.PoolHash>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolHashReadModel, CGQL.NET.Server.Domain.Models.PoolHashUpdateModel>();

        }

    }
}
