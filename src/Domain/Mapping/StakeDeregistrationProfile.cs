using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class StakeDeregistrationProfile
        : AutoMapper.Profile
    {
        public StakeDeregistrationProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.StakeDeregistration, CGQL.NET.Server.Domain.Models.StakeDeregistrationReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeDeregistrationCreateModel, CGQL.NET.Server.Data.Entities.StakeDeregistration>();

            CreateMap<CGQL.NET.Server.Data.Entities.StakeDeregistration, CGQL.NET.Server.Domain.Models.StakeDeregistrationUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeDeregistrationUpdateModel, CGQL.NET.Server.Data.Entities.StakeDeregistration>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeDeregistrationReadModel, CGQL.NET.Server.Domain.Models.StakeDeregistrationUpdateModel>();

        }

    }
}
