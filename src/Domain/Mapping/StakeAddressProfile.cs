using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class StakeAddressProfile
        : AutoMapper.Profile
    {
        public StakeAddressProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.StakeAddress, CGQL.NET.Server.Domain.Models.StakeAddressReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeAddressCreateModel, CGQL.NET.Server.Data.Entities.StakeAddress>();

            CreateMap<CGQL.NET.Server.Data.Entities.StakeAddress, CGQL.NET.Server.Domain.Models.StakeAddressUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeAddressUpdateModel, CGQL.NET.Server.Data.Entities.StakeAddress>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeAddressReadModel, CGQL.NET.Server.Domain.Models.StakeAddressUpdateModel>();

        }

    }
}
