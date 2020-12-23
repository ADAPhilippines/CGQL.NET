using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class UtxoViewProfile
        : AutoMapper.Profile
    {
        public UtxoViewProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.UtxoView, CGQL.NET.Server.Domain.Models.UtxoViewReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.UtxoViewCreateModel, CGQL.NET.Server.Data.Entities.UtxoView>();

            CreateMap<CGQL.NET.Server.Data.Entities.UtxoView, CGQL.NET.Server.Domain.Models.UtxoViewUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.UtxoViewUpdateModel, CGQL.NET.Server.Data.Entities.UtxoView>();

            CreateMap<CGQL.NET.Server.Domain.Models.UtxoViewReadModel, CGQL.NET.Server.Domain.Models.UtxoViewUpdateModel>();

        }

    }
}
