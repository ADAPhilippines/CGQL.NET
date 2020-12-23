using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class RewardProfile
        : AutoMapper.Profile
    {
        public RewardProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Reward, CGQL.NET.Server.Domain.Models.RewardReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.RewardCreateModel, CGQL.NET.Server.Data.Entities.Reward>();

            CreateMap<CGQL.NET.Server.Data.Entities.Reward, CGQL.NET.Server.Domain.Models.RewardUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.RewardUpdateModel, CGQL.NET.Server.Data.Entities.Reward>();

            CreateMap<CGQL.NET.Server.Domain.Models.RewardReadModel, CGQL.NET.Server.Domain.Models.RewardUpdateModel>();

        }

    }
}
