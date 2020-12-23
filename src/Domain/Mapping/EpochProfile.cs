using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class EpochProfile
        : AutoMapper.Profile
    {
        public EpochProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Epoch, CGQL.NET.Server.Domain.Models.EpochReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochCreateModel, CGQL.NET.Server.Data.Entities.Epoch>();

            CreateMap<CGQL.NET.Server.Data.Entities.Epoch, CGQL.NET.Server.Domain.Models.EpochUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochUpdateModel, CGQL.NET.Server.Data.Entities.Epoch>();

            CreateMap<CGQL.NET.Server.Domain.Models.EpochReadModel, CGQL.NET.Server.Domain.Models.EpochUpdateModel>();

        }

    }
}
