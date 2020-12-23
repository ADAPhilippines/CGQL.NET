using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class TxProfile
        : AutoMapper.Profile
    {
        public TxProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Tx, CGQL.NET.Server.Domain.Models.TxReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxCreateModel, CGQL.NET.Server.Data.Entities.Tx>();

            CreateMap<CGQL.NET.Server.Data.Entities.Tx, CGQL.NET.Server.Domain.Models.TxUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxUpdateModel, CGQL.NET.Server.Data.Entities.Tx>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxReadModel, CGQL.NET.Server.Domain.Models.TxUpdateModel>();

        }

    }
}
