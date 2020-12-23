using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class MaTxOutProfile
        : AutoMapper.Profile
    {
        public MaTxOutProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.MaTxOut, CGQL.NET.Server.Domain.Models.MaTxOutReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.MaTxOutCreateModel, CGQL.NET.Server.Data.Entities.MaTxOut>();

            CreateMap<CGQL.NET.Server.Data.Entities.MaTxOut, CGQL.NET.Server.Domain.Models.MaTxOutUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.MaTxOutUpdateModel, CGQL.NET.Server.Data.Entities.MaTxOut>();

            CreateMap<CGQL.NET.Server.Domain.Models.MaTxOutReadModel, CGQL.NET.Server.Domain.Models.MaTxOutUpdateModel>();

        }

    }
}
