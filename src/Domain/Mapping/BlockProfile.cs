using System;
using AutoMapper;
using CGQL.NET.Server.Data.Entities;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Mapping
{
    public partial class BlockProfile
        : AutoMapper.Profile
    {
        public BlockProfile()
        {
            CreateMap<CGQL.NET.Server.Data.Entities.Block, CGQL.NET.Server.Domain.Models.BlockReadModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.BlockCreateModel, CGQL.NET.Server.Data.Entities.Block>();

            CreateMap<CGQL.NET.Server.Data.Entities.Block, CGQL.NET.Server.Domain.Models.BlockUpdateModel>();

            CreateMap<CGQL.NET.Server.Domain.Models.BlockUpdateModel, CGQL.NET.Server.Data.Entities.Block>();

            CreateMap<CGQL.NET.Server.Domain.Models.BlockReadModel, CGQL.NET.Server.Domain.Models.BlockUpdateModel>();

        }

    }
}
