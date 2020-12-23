using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class ReserveProfile
        : AutoMapper.Profile
    {
        public ReserveProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Reserve, CGQL.NET.Server.Domain.Models.ReserveReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.ReserveCreateModel, CGQL.NET.Server.Data.Entities.Reserve>();

            CreateMap<CGQL.NET.Server.Data.Entities.Reserve, CGQL.NET.Server.Domain.Models.ReserveUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.ReserveUpdateModel, CGQL.NET.Server.Data.Entities.Reserve>();

            CreateMap<CGQL.NET.Server.Domain.Models.ReserveReadModel, CGQL.NET.Server.Domain.Models.ReserveUpdateModel>();

        }

    }
}
