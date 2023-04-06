using FluentValidation;
using LeaveManagement_Backend.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;


namespace LeaveManagement_Backend.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            /*  RuleFor(p => p.Name)
                   .NotEmpty().WithMessage("{PrpertyName} is required")
                   .NotNull()
                  .MaximumLength(50).WithMessage("{PrpertyName} must not exced 50 characters");

              RuleFor(p => p.DefaultDays)
                   .NotEmpty().WithMessage("{PrpertyName} is required")
                   .GreaterThan(0).WithMessage("{PrpertyName} must be at least 1.")
                   .LessThan(100).WithMessage("{PrpertyName} must be less than 100");*/
            Include(new ILeaveTypeDtoValidator());

        }
            


        }
   
}