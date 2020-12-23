using System;
using FluentValidation;
using CGQL.NET.Server.Domain.Models;

namespace CGQL.NET.Server.Domain.Validation
{
    public partial class SlotLeaderCreateModelValidator
        : AbstractValidator<SlotLeaderCreateModel>
    {
        public SlotLeaderCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Description).NotEmpty();
            #endregion
        }

    }
}
