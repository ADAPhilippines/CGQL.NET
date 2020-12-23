using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class StakeRegistrationProfile
        : AutoMapper.Profile
    {
        public StakeRegistrationProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.StakeRegistration, CGQL.NET.Server.Domain.Models.StakeRegistrationReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeRegistrationCreateModel, CGQL.NET.Server.Data.Entities.StakeRegistration>();

            CreateMap<CGQL.NET.Server.Data.Entities.StakeRegistration, CGQL.NET.Server.Domain.Models.StakeRegistrationUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeRegistrationUpdateModel, CGQL.NET.Server.Data.Entities.StakeRegistration>();

            CreateMap<CGQL.NET.Server.Domain.Models.StakeRegistrationReadModel, CGQL.NET.Server.Domain.Models.StakeRegistrationUpdateModel>();

        }

    }
}
