using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class MetaProfile
        : AutoMapper.Profile
    {
        public MetaProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Meta, CGQL.NET.Server.Domain.Models.MetaReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.MetaCreateModel, CGQL.NET.Server.Data.Entities.Meta>();

            CreateMap<CGQL.NET.Server.Data.Entities.Meta, CGQL.NET.Server.Domain.Models.MetaUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.MetaUpdateModel, CGQL.NET.Server.Data.Entities.Meta>();

            CreateMap<CGQL.NET.Server.Domain.Models.MetaReadModel, CGQL.NET.Server.Domain.Models.MetaUpdateModel>();

        }

    }
}
