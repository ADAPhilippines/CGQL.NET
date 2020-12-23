using System;
using FluentValidation;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Validation
{
    public partial class StakeAddressCreateModelValidator
        : AbstractValidator<StakeAddressCreateModel>
    {
        public StakeAddressCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.View).NotEmpty();
            #endregion
        }

    }
}
