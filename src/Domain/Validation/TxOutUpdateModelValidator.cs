using System;
using FluentValidation;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Validation
{
    public partial class TxOutUpdateModelValidator
        : AbstractValidator<TxOutUpdateModel>
    {
        public TxOutUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Address).NotEmpty();
            #endregion
        }

    }
}
