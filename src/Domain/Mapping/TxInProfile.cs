using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class TxInProfile
        : AutoMapper.Profile
    {
        public TxInProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.TxIn, CGQL.NET.Server.Domain.Models.TxInReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxInCreateModel, CGQL.NET.Server.Data.Entities.TxIn>();

            CreateMap<CGQL.NET.Server.Data.Entities.TxIn, CGQL.NET.Server.Domain.Models.TxInUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxInUpdateModel, CGQL.NET.Server.Data.Entities.TxIn>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxInReadModel, CGQL.NET.Server.Domain.Models.TxInUpdateModel>();

        }

    }
}
