using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class SlotLeaderProfile
        : AutoMapper.Profile
    {
        public SlotLeaderProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.SlotLeader, CGQL.NET.Server.Domain.Models.SlotLeaderReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.SlotLeaderCreateModel, CGQL.NET.Server.Data.Entities.SlotLeader>();

            CreateMap<CGQL.NET.Server.Data.Entities.SlotLeader, CGQL.NET.Server.Domain.Models.SlotLeaderUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.SlotLeaderUpdateModel, CGQL.NET.Server.Data.Entities.SlotLeader>();

            CreateMap<CGQL.NET.Server.Domain.Models.SlotLeaderReadModel, CGQL.NET.Server.Domain.Models.SlotLeaderUpdateModel>();

        }

    }
}
