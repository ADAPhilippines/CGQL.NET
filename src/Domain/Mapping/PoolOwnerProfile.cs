using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class PoolOwnerProfile
        : AutoMapper.Profile
    {
        public PoolOwnerProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.PoolOwner, CGQL.NET.Server.Domain.Models.PoolOwnerReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolOwnerCreateModel, CGQL.NET.Server.Data.Entities.PoolOwner>();

            CreateMap<CGQL.NET.Server.Data.Entities.PoolOwner, CGQL.NET.Server.Domain.Models.PoolOwnerUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolOwnerUpdateModel, CGQL.NET.Server.Data.Entities.PoolOwner>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolOwnerReadModel, CGQL.NET.Server.Domain.Models.PoolOwnerUpdateModel>();

        }

    }
}
