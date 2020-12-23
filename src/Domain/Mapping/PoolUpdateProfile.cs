using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class PoolUpdateProfile
        : AutoMapper.Profile
    {
        public PoolUpdateProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.PoolUpdate, CGQL.NET.Server.Domain.Models.PoolUpdateReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolUpdateCreateModel, CGQL.NET.Server.Data.Entities.PoolUpdate>();

            CreateMap<CGQL.NET.Server.Data.Entities.PoolUpdate, CGQL.NET.Server.Domain.Models.PoolUpdateUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolUpdateUpdateModel, CGQL.NET.Server.Data.Entities.PoolUpdate>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolUpdateReadModel, CGQL.NET.Server.Domain.Models.PoolUpdateUpdateModel>();

        }

    }
}
