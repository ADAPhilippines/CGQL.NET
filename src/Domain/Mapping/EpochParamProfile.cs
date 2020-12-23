using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class EpochParamProfile
        : AutoMapper.Profile
    {
        public EpochParamProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.EpochParam, CGQL.NET.Server.Domain.Models.EpochParamReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochParamCreateModel, CGQL.NET.Server.Data.Entities.EpochParam>();

            CreateMap<CGQL.NET.Server.Data.Entities.EpochParam, CGQL.NET.Server.Domain.Models.EpochParamUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochParamUpdateModel, CGQL.NET.Server.Data.Entities.EpochParam>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochParamReadModel, CGQL.NET.Server.Domain.Models.EpochParamUpdateModel>();

        }

    }
}
