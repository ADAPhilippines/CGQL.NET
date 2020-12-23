using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class EpochStakeProfile
        : AutoMapper.Profile
    {
        public EpochStakeProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.EpochStake, CGQL.NET.Server.Domain.Models.EpochStakeReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochStakeCreateModel, CGQL.NET.Server.Data.Entities.EpochStake>();

            CreateMap<CGQL.NET.Server.Data.Entities.EpochStake, CGQL.NET.Server.Domain.Models.EpochStakeUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochStakeUpdateModel, CGQL.NET.Server.Data.Entities.EpochStake>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochStakeReadModel, CGQL.NET.Server.Domain.Models.EpochStakeUpdateModel>();

        }

    }
}
