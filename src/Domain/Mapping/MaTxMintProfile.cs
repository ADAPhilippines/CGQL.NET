using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class MaTxMintProfile
        : AutoMapper.Profile
    {
        public MaTxMintProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.MaTxMint, CGQL.NET.Server.Domain.Models.MaTxMintReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.MaTxMintCreateModel, CGQL.NET.Server.Data.Entities.MaTxMint>();

            CreateMap<CGQL.NET.Server.Data.Entities.MaTxMint, CGQL.NET.Server.Domain.Models.MaTxMintUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.MaTxMintUpdateModel, CGQL.NET.Server.Data.Entities.MaTxMint>();

            CreateMap<CGQL.NET.Server.Domain.Models.MaTxMintReadModel, CGQL.NET.Server.Domain.Models.MaTxMintUpdateModel>();

        }

    }
}
