using System;
using FluentValidation;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Validation
{
    public partial class PoolMetaDataCreateModelValidator
        : AbstractValidator<PoolMetaDataCreateModel>
    {
        public PoolMetaDataCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Url).NotEmpty();
            #endregion
        }

    }
}
