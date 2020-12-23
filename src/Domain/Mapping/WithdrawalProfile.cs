using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class WithdrawalProfile
        : AutoMapper.Profile
    {
        public WithdrawalProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Withdrawal, CGQL.NET.Server.Domain.Models.WithdrawalReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.WithdrawalCreateModel, CGQL.NET.Server.Data.Entities.Withdrawal>();

            CreateMap<CGQL.NET.Server.Data.Entities.Withdrawal, CGQL.NET.Server.Domain.Models.WithdrawalUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.WithdrawalUpdateModel, CGQL.NET.Server.Data.Entities.Withdrawal>();

            CreateMap<CGQL.NET.Server.Domain.Models.WithdrawalReadModel, CGQL.NET.Server.Domain.Models.WithdrawalUpdateModel>();

        }

    }
}
