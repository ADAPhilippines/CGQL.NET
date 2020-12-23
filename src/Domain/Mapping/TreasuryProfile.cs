using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class TreasuryProfile
        : AutoMapper.Profile
    {
        public TreasuryProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Treasury, CGQL.NET.Server.Domain.Models.TreasuryReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TreasuryCreateModel, CGQL.NET.Server.Data.Entities.Treasury>();

            CreateMap<CGQL.NET.Server.Data.Entities.Treasury, CGQL.NET.Server.Domain.Models.TreasuryUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TreasuryUpdateModel, CGQL.NET.Server.Data.Entities.Treasury>();

            CreateMap<CGQL.NET.Server.Domain.Models.TreasuryReadModel, CGQL.NET.Server.Domain.Models.TreasuryUpdateModel>();

        }

    }
}
