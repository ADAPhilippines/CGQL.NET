using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class PoolMetaDataProfile
        : AutoMapper.Profile
    {
        public PoolMetaDataProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.PoolMetaData, CGQL.NET.Server.Domain.Models.PoolMetaDataReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolMetaDataCreateModel, CGQL.NET.Server.Data.Entities.PoolMetaData>();

            CreateMap<CGQL.NET.Server.Data.Entities.PoolMetaData, CGQL.NET.Server.Domain.Models.PoolMetaDataUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolMetaDataUpdateModel, CGQL.NET.Server.Data.Entities.PoolMetaData>();

            CreateMap<CGQL.NET.Server.Domain.Models.PoolMetaDataReadModel, CGQL.NET.Server.Domain.Models.PoolMetaDataUpdateModel>();

        }

    }
}
