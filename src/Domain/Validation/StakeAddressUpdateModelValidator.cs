using System;
using FluentValidation;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Validation
{
    public partial class StakeAddressUpdateModelValidator
        : AbstractValidator<StakeAddressUpdateModel>
    {
        public StakeAddressUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.View).NotEmpty();
            #endregion
        }

    }
}
