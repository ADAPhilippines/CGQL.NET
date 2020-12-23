using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class TxOutProfile
        : AutoMapper.Profile
    {
        public TxOutProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.TxOut, CGQL.NET.Server.Domain.Models.TxOutReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxOutCreateModel, CGQL.NET.Server.Data.Entities.TxOut>();

            CreateMap<CGQL.NET.Server.Data.Entities.TxOut, CGQL.NET.Server.Domain.Models.TxOutUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxOutUpdateModel, CGQL.NET.Server.Data.Entities.TxOut>();

            CreateMap<CGQL.NET.Server.Domain.Models.TxOutReadModel, CGQL.NET.Server.Domain.Models.TxOutUpdateModel>();

        }

    }
}
