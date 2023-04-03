using FluentValidation;
using LeaveManagement_Backend.Application.DTOs.TypeRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.DTOs.LeaveType.Validators
{
     public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{ProprietyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{ProprietyName} must not exced 50 character.");
            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{ProprietyName} is required.")
                .GreaterThan(0).WithMessage("{ProprietyName} must be at least 1.")
                .LessThan(100).WithMessage("{ProprietyName} must be less than {ComparisonValue}.");

        }

      
    }
  
}
