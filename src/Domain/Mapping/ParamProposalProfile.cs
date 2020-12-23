using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class ParamProposalProfile
        : AutoMapper.Profile
    {
        public ParamProposalProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.ParamProposal, CGQL.NET.Server.Domain.Models.ParamProposalReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.ParamProposalCreateModel, CGQL.NET.Server.Data.Entities.ParamProposal>();

            CreateMap<CGQL.NET.Server.Data.Entities.ParamProposal, CGQL.NET.Server.Domain.Models.ParamProposalUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.ParamProposalUpdateModel, CGQL.NET.Server.Data.Entities.ParamProposal>();

            CreateMap<CGQL.NET.Server.Domain.Models.ParamProposalReadModel, CGQL.NET.Server.Domain.Models.ParamProposalUpdateModel>();

        }

    }
}
