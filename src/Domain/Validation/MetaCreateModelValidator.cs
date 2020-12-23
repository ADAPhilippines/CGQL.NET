using System;
using FluentValidation;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Validation
{
    public partial class MetaCreateModelValidator
        : AbstractValidator<MetaCreateModel>
    {
        public MetaCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NetworkName).NotEmpty();
            #endregion
        }

    }
}
