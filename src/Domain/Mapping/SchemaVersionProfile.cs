using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class SchemaVersionProfile
        : AutoMapper.Profile
    {
        public SchemaVersionProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.SchemaVersion, CGQL.NET.Server.Domain.Models.SchemaVersionReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.SchemaVersionCreateModel, CGQL.NET.Server.Data.Entities.SchemaVersion>();

            CreateMap<CGQL.NET.Server.Data.Entities.SchemaVersion, CGQL.NET.Server.Domain.Models.SchemaVersionUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.SchemaVersionUpdateModel, CGQL.NET.Server.Data.Entities.SchemaVersion>();

            CreateMap<CGQL.NET.Server.Domain.Models.SchemaVersionReadModel, CGQL.NET.Server.Domain.Models.SchemaVersionUpdateModel>();

        }

    }
}
