using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class DelegationProfile
        : AutoMapper.Profile
    {
        public DelegationProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Delegation, CGQL.NET.Server.Domain.Models.DelegationReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.DelegationCreateModel, CGQL.NET.Server.Data.Entities.Delegation>();

            CreateMap<CGQL.NET.Server.Data.Entities.Delegation, CGQL.NET.Server.Domain.Models.DelegationUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.DelegationUpdateModel, CGQL.NET.Server.Data.Entities.Delegation>();

            CreateMap<CGQL.NET.Server.Domain.Models.DelegationReadModel, CGQL.NET.Server.Domain.Models.DelegationUpdateModel>();

        }

    }
}
