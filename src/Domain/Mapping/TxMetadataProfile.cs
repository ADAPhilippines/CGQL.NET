using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class TxMetadataProfile
        : AutoMapper.Profile
    {
        public TxMetadataProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.TxMetadata, CGQL.NET.Server.Domain.Models.TxMetadataReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxMetadataCreateModel, CGQL.NET.Server.Data.Entities.TxMetadata>();

            CreateMap<CGQL.NET.Server.Data.Entities.TxMetadata, CGQL.NET.Server.Domain.Models.TxMetadataUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxMetadataUpdateModel, CGQL.NET.Server.Data.Entities.TxMetadata>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxMetadataReadModel, CGQL.NET.Server.Domain.Models.TxMetadataUpdateModel>();

        }

    }
}
