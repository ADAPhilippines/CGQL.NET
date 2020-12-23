using System;
using FluentValidation;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Validation
{
    public partial class MetaUpdateModelValidator
        : AbstractValidator<MetaUpdateModel>
    {
        public MetaUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NetworkName).NotEmpty();
            #endregion
        }

    }
}
